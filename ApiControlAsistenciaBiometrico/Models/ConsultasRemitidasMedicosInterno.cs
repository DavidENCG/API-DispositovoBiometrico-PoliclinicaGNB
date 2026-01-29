using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ConsultasRemitidasMedicosInterno
{
    public int Id { get; set; }

    public int? idCitaMedica { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public string? NroInterconsulta { get; set; }

    public string? Observaciones { get; set; }

    public decimal? Costo { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public int? idAsignada { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ResRapidum? idAsignadaNavigation { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual CitasMedica? idCitaMedicaNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
