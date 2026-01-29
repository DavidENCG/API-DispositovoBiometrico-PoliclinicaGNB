using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Diagnostico
{
    public int Id { get; set; }

    public int? idCedulaPciente { get; set; }

    public string? idNroCaso { get; set; }

    public string? Diagnostico1 { get; set; }

    public int? idMedico { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? ClinicaId { get; set; }

    public string? PrefijoDepartamento { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPcienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
