using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PacienteOncologico
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public int? idPacienteOncologico { get; set; }

    public int? idRecibeQuimio { get; set; }

    public string? Especificar { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }

    public virtual ResRapidum? idPacienteOncologicoNavigation { get; set; }

    public virtual ResRapidum? idRecibeQuimioNavigation { get; set; }
}
