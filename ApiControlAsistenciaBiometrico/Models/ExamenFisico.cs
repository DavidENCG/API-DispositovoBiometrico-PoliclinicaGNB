using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ExamenFisico
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public string? TensionArterial { get; set; }

    public string? FrecuenciaCardiaca { get; set; }

    public string? FrecuenciaRespiratoria { get; set; }

    public string? Temperatura { get; set; }

    public string? Peso { get; set; }

    public string? Talla { get; set; }

    public string? FisicoAspectoGeneral { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? idMedico { get; set; }

    public int? ClinicaId { get; set; }

    public string? PrefijoDepartamento { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<ExamenFisico2> ExamenFisico2s { get; set; } = new List<ExamenFisico2>();

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
