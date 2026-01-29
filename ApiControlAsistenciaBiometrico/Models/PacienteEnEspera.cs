using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PacienteEnEspera
{
    public int Id { get; set; }

    public int? idPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public string? Sintomas { get; set; }

    public DateTime? DateIngreso { get; set; }

    public DateTime? DateSalida { get; set; }

    public TimeOnly? TiempoEnEspera { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idPacienteNavigation { get; set; }
}
