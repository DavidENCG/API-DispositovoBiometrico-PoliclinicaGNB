using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Recipe
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public int? idMedico { get; set; }

    public string? Observaciones { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string? Indicaciones { get; set; }

    public int? ClinicaId { get; set; }

    public string? PrefijoDepartamento { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
