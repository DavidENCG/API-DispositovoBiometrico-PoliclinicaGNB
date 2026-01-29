using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class BiometricoMarcaje
{
    public long Id { get; set; }

    public int DispositivoId { get; set; }

    public int UsuarioId { get; set; }

    public DateTime FechaHoraMarcajeUtc { get; set; }

    public string? TipoMarcaje { get; set; }

    public string Fuente { get; set; } = null!;

    public byte[] HashIdempotencia { get; set; } = null!;

    public DateTime CreadoUtc { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual BiometricoDispositivo Dispositivo { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
