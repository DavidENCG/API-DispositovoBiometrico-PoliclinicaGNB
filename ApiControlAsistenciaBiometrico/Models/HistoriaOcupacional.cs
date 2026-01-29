using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class HistoriaOcupacional
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public int? idMedico { get; set; }

    public int? idEstadoEvaluacionMedica { get; set; }

    public string? EvaluacionMedica { get; set; }

    public string? Archivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual EstadoSintoma? idEstadoEvaluacionMedicaNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
