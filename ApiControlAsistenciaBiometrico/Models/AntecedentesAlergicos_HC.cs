using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesAlergicos_HC
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public string? Alergia { get; set; }

    public string? Reaccion { get; set; }

    public string? Medicamento { get; set; }

    public bool? Complicacion { get; set; }

    public string? Observaciones { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
