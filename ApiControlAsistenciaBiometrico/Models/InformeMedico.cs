using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class InformeMedico
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public int? idMedico { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? ClinicaId { get; set; }

    public string? PrefijoDepartamento { get; set; }

    public int? idTipoInforme { get; set; }

    public bool? IncluirExamenesRealizados { get; set; }

    public bool? SolicitudAtendida { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<HistorialEvolucion> HistorialEvolucions { get; set; } = new List<HistorialEvolucion>();

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }

    public virtual TipoInformeMedico? idTipoInformeNavigation { get; set; }
}
