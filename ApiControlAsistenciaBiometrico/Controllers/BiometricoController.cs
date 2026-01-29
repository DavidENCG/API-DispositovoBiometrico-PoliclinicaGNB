using ApiControlAsistenciaBiometrico.Data;
using ApiControlAsistenciaBiometrico.Models;
using ApiControlAsistenciaBiometrico.Models.ViewModels.Biometrico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace ApiControlAsistenciaBiometrico.Controllers;

[ApiController]
[Route("api/biometrico")]
public class BiometricoController : ControllerBase
{
    private readonly AppDbContext _db;

    public BiometricoController(AppDbContext db) => _db = db;

    // -------------------------
    // A) DISPOSITIVOS
    // -------------------------

    [HttpPost("dispositivos")]
    public async Task<ActionResult<DispositivoResponseVm>> RegistrarDispositivo(
        [FromBody] RegistrarDispositivoRequestVm vm,
        CancellationToken ct)
    {
        if (string.IsNullOrWhiteSpace(vm.Nombre))
            return BadRequest("Nombre es requerido.");

        var entity = new BiometricoDispositivo
        {
            ClinicaId = vm.ClinicaId,
            Nombre = vm.Nombre,
            Serial = vm.Serial,
            MarcaModelo = vm.MarcaModelo,
            Activo = true,
            Creado = DateTime.UtcNow
        };

        _db.BiometricoDispositivos.Add(entity);
        await _db.SaveChangesAsync(ct);

        return Ok(new DispositivoResponseVm
        {
            Id = entity.Id,
            ClinicaId = entity.ClinicaId,
            Nombre = entity.Nombre,
            Serial = entity.Serial,
            Activo = entity.Activo ?? true,
            UltimoSyncUtc = entity.UltimoSyncUtc
        });
    }

    [HttpGet("dispositivos/{id:int}")]
    public async Task<ActionResult<DispositivoResponseVm>> ObtenerDispositivo(int id, CancellationToken ct)
    {
        var d = await _db.BiometricoDispositivos.FirstOrDefaultAsync(x => x.Id == id, ct);
        if (d is null) return NotFound();

        return Ok(new DispositivoResponseVm
        {
            Id = d.Id,
            ClinicaId = d.ClinicaId,
            Nombre = d.Nombre,
            Serial = d.Serial,
            Activo = d.Activo ?? true,
            UltimoSyncUtc = d.UltimoSyncUtc
        });
    }

    // -------------------------
    // B) MARCAJES (BATCH)
    // -------------------------

    [HttpPost("marcajes/batch")]
    public async Task<ActionResult<BatchMarcajesResponseVm>> RecibirBatch(
        [FromBody] BatchMarcajesRequestVm req,
        CancellationToken ct)
    {
        if (string.IsNullOrWhiteSpace(req.AgentKey))
            return BadRequest("AgentKey requerido.");

        if (req.DispositivoId <= 0)
            return BadRequest("DispositivoId requerido.");

        if (req.Marcajes is null || req.Marcajes.Count == 0)
        {
            await UpsertSyncEstado(req.AgentKey, req.DispositivoId, ct);
            return Ok(new BatchMarcajesResponseVm
            {
                Recibidos = 0,
                Insertados = 0,
                Duplicados = 0,
                Rechazados = 0,
                ServerUtc = DateTime.UtcNow
            });
        }

        // Validar dispositivo (y opcionalmente clinica)
        var dispositivo = await _db.BiometricoDispositivos
            .FirstOrDefaultAsync(x => x.Id == req.DispositivoId, ct);

        if (dispositivo is null) return BadRequest("DispositivoId no existe.");
        if (dispositivo.Activo == false) return BadRequest("Dispositivo inactivo.");

        int insertados = 0, duplicados = 0, rechazados = 0;

        // Mejorable a insert masivo; por ahora robusto y claro.
        foreach (var m in req.Marcajes)
        {
            if (m.PersonCode <= 0)
            {
                rechazados++;
                continue;
            }

            // (Recomendado) validar que el usuario existe
            var existeUsuario = await _db.Usuarios.AnyAsync(u => u.Id == m.PersonCode, ct);
            if (!existeUsuario)
            {
                rechazados++;
                continue;
            }

            var hash = ComputeHash(req.DispositivoId, m.PersonCode, m.FechaHoraUtc, m.TipoMarcaje, m.RecordIdLocal);

            var entity = new BiometricoMarcaje
            {
                DispositivoId = req.DispositivoId,
                UsuarioId = m.PersonCode,
                FechaHoraMarcajeUtc = DateTime.SpecifyKind(m.FechaHoraUtc, DateTimeKind.Utc),
                //FechaHoraMarcajeLocal = m.FechaHoraLocal,
                TipoMarcaje = m.TipoMarcaje,
                Fuente = "device",
                HashIdempotencia = hash,
                ClinicaId = req.ClinicaId,
                CreadoUtc = DateTime.UtcNow
            };

            _db.BiometricoMarcajes.Add(entity);

            try
            {
                await _db.SaveChangesAsync(ct);
                insertados++;
            }
            catch (DbUpdateException ex) when (IsUniqueViolation(ex))
            {
                duplicados++;
                _db.Entry(entity).State = EntityState.Detached;
            }
            catch
            {
                rechazados++;
                _db.Entry(entity).State = EntityState.Detached;
            }
        }

        // actualizar last sync + ultimo sync del dispositivo
        await UpsertSyncEstado(req.AgentKey, req.DispositivoId, ct);
        dispositivo.UltimoSyncUtc = DateTime.UtcNow;
        await _db.SaveChangesAsync(ct);

        return Ok(new BatchMarcajesResponseVm
        {
            Recibidos = req.Marcajes.Count,
            Insertados = insertados,
            Duplicados = duplicados,
            Rechazados = rechazados,
            ServerUtc = DateTime.UtcNow
        });

    }

    // Auditoría básica
    [HttpGet("marcajes")]
    public async Task<ActionResult<List<MarcajeDto>>> ObtenerMarcajes(
        [FromQuery] int usuarioId,
        [FromQuery] DateTime desdeUtc,
        [FromQuery] DateTime hastaUtc,
        CancellationToken ct)
    {
        if (usuarioId <= 0) return BadRequest("usuarioId requerido.");
        if (hastaUtc <= desdeUtc) return BadRequest("Rango de fechas inválido.");

        var data = await _db.BiometricoMarcajes
            .Where(x => x.UsuarioId == usuarioId &&
                        x.FechaHoraMarcajeUtc >= desdeUtc &&
                        x.FechaHoraMarcajeUtc <= hastaUtc)
            .OrderBy(x => x.FechaHoraMarcajeUtc)
            .Select(x => new MarcajeDto
            {
                PersonCode = x.UsuarioId,
                FechaHoraUtc = x.FechaHoraMarcajeUtc,
                FechaHoraLocal = x.FechaHoraMarcajeUtc,
                TipoMarcaje = x.TipoMarcaje,
                RecordIdLocal = null // no lo tienes en DB actual, si luego lo agregas lo mapeas aquí
            })
            .ToListAsync(ct);

        return Ok(data);
    }

    // -------------------------
    // C) ESTADO DE SYNC
    // -------------------------

    [HttpGet("sync/estado")]
    public async Task<ActionResult<SyncEstadoResponseVm>> GetSyncEstado([FromQuery] string agentKey, CancellationToken ct)
    {
        if (string.IsNullOrWhiteSpace(agentKey))
            return BadRequest("agentKey requerido.");

        var sync = await _db.BiometricoSyncEstados.FirstOrDefaultAsync(x => x.AgentKey == agentKey, ct);

        return Ok(new SyncEstadoResponseVm
        {
            AgentKey = agentKey,
            DispositivoId = sync?.DispositivoId,
            UltimoPushUtc = sync?.UltimoPushUtc,
            ServerUtc = DateTime.UtcNow
        });
    }

    // -------------------------
    // Helpers
    // -------------------------

    private async Task UpsertSyncEstado(string agentKey, int dispositivoId, CancellationToken ct)
    {
        var sync = await _db.BiometricoSyncEstados.FirstOrDefaultAsync(x => x.AgentKey == agentKey, ct);

        if (sync is null)
        {
            sync = new BiometricoSyncEstado
            {
                AgentKey = agentKey,
                DispositivoId = dispositivoId,
                UltimoPushUtc = DateTime.UtcNow,
                CreadoUtc = DateTime.UtcNow
            };
            _db.BiometricoSyncEstados.Add(sync);
        }
        else
        {
            sync.DispositivoId = dispositivoId;
            sync.UltimoPushUtc = DateTime.UtcNow;
        }

        await _db.SaveChangesAsync(ct);
    }

    private static byte[] ComputeHash(int dispositivoId, int usuarioId, DateTime fechaHoraUtc, string? tipo, long? recordIdLocal)
    {
        var s = recordIdLocal.HasValue
            ? $"{dispositivoId}|{recordIdLocal.Value}"
            : $"{dispositivoId}|{usuarioId}|{fechaHoraUtc:O}|{tipo ?? "NULL"}";

        return SHA256.HashData(Encoding.UTF8.GetBytes(s));
    }

    private static bool IsUniqueViolation(DbUpdateException ex)
    {
        // SQL Server unique violation: 2601 or 2627
        var msg = ex.InnerException?.Message ?? ex.Message;
        return msg.Contains("2601") || msg.Contains("2627");
    }
}
