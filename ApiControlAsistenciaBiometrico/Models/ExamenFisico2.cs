using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ExamenFisico2
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public int? idMedico { get; set; }

    public int? idExamenes_ExamenFisico { get; set; }

    public int? idZonaExamenFisico { get; set; }

    public int? idDLN { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public int? ExamenFisicoId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ExamenFisico? ExamenFisico { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual DLN? idDLNNavigation { get; set; }

    public virtual Examenes_ExamenFisico? idExamenes_ExamenFisicoNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }

    public virtual ZonaExamenFisico? idZonaExamenFisicoNavigation { get; set; }
}
