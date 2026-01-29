using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoDeSangre
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public int? idClasificacionSangre { get; set; }

    public int? idFactorRH { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual ClasificacionSangre? idClasificacionSangreNavigation { get; set; }

    public virtual FactorRH? idFactorRHNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
