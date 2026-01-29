using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class HistorialEvolucion
{
    public int Id { get; set; }

    public int InformeMedicoId { get; set; }

    public DateTime Fecha { get; set; }

    public string Profesional { get; set; } = null!;

    public int? EvaluacionEstado { get; set; }

    public string? Descripcion { get; set; }

    public string? idMedico { get; set; }

    public string? PrefijoDepartamento { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual InformeMedico InformeMedico { get; set; } = null!;
}
