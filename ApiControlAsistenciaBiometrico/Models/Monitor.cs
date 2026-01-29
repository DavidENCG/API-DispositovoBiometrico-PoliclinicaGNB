using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Monitor
{
    public int Id { get; set; }

    public int? IdCita { get; set; }

    public string? CodigoCita { get; set; }

    public string? NombrePaciente { get; set; }

    public string? CedulaPaciente { get; set; }

    public string? CategoriaItem { get; set; }

    public string? Item { get; set; }

    public string? Proveedor { get; set; }

    public int? IdLlamado { get; set; }

    public string? Llamado { get; set; }

    public int? CantidadLlamado { get; set; }

    public bool? EstadoLlamado { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
