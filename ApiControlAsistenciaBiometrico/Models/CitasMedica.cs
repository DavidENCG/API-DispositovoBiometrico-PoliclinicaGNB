using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class CitasMedica
{
    public int Id { get; set; }

    public int idCedulaPaciente { get; set; }

    public string? NroCaso { get; set; }

    public DateOnly? FechaCita { get; set; }

    public string? HoraCita { get; set; }

    public int? idStatusCaso { get; set; }

    public int? idMedico { get; set; }

    public int? idStatusCita { get; set; }

    public int? idMotivoConsulta { get; set; }

    public string? MotivoDescripcion { get; set; }

    public string? nombrePaciente { get; set; }

    public string? ciPaciente { get; set; }

    public string? casoConsulta { get; set; }

    public string? lastnamePaciente { get; set; }

    public int? idTipoCliente { get; set; }

    public int? idCliente { get; set; }

    public int? idEspecialidad { get; set; }

    public int? idItems { get; set; }

    public int? idMedicoInterconsulta { get; set; }

    public int? idInterconsulta { get; set; }

    public int? userCreated { get; set; }

    public DateTime? dateCreated { get; set; }

    public int? idConfirmada { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalBs { get; set; }

    public decimal? TasaCambio { get; set; }

    public decimal? PorPagar { get; set; }

    public int? idStatusFacturacion { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<ConsultasRemitidasMedicosInterno> ConsultasRemitidasMedicosInternos { get; set; } = new List<ConsultasRemitidasMedicosInterno>();

    public virtual Paciente idCedulaPacienteNavigation { get; set; } = null!;

    public virtual Cliente? idClienteNavigation { get; set; }

    public virtual StatusConfirmacion? idConfirmadaNavigation { get; set; }

    public virtual Especialidade? idEspecialidadNavigation { get; set; }

    public virtual ResRapidum? idInterconsultaNavigation { get; set; }

    public virtual Item? idItemsNavigation { get; set; }

    public virtual Usuario? idMedicoInterconsultaNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }

    public virtual MotivoConsultum? idMotivoConsultaNavigation { get; set; }

    public virtual StatusCaso? idStatusCasoNavigation { get; set; }

    public virtual StatusCitum? idStatusCitaNavigation { get; set; }

    public virtual StatusFacturacion? idStatusFacturacionNavigation { get; set; }

    public virtual TipoCliente? idTipoClienteNavigation { get; set; }

    public virtual Usuario? userCreatedNavigation { get; set; }
}
