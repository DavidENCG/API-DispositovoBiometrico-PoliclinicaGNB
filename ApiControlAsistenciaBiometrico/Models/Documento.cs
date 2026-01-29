using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Documento
{
    public int Id { get; set; }

    public int PacienteId { get; set; }

    public string CasoCodigo { get; set; } = null!;

    public string NombreArchivoOriginal { get; set; } = null!;

    public string NombreArchivoGuardado { get; set; } = null!;

    public string RutaArchivo { get; set; } = null!;

    public string TipoContenido { get; set; } = null!;

    public long TamañoArchivo { get; set; }

    public DateTime FechaSubida { get; set; }

    public int UsuarioSubidaId { get; set; }

    public string? Descripcion { get; set; }

    public bool Activo { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente Paciente { get; set; } = null!;

    public virtual Usuario UsuarioSubida { get; set; } = null!;
}
