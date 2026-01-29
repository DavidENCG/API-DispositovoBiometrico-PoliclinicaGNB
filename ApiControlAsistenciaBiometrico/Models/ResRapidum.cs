using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ResRapidum
{
    public int Id { get; set; }

    public string? Respuesta { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<CitasMedica> CitasMedicas { get; set; } = new List<CitasMedica>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<ConsultasRemitidasMedicosInterno> ConsultasRemitidasMedicosInternos { get; set; } = new List<ConsultasRemitidasMedicosInterno>();

    public virtual ICollection<OrdenDeServicio> OrdenDeServicioidConfirmacionEntregaNavigations { get; set; } = new List<OrdenDeServicio>();

    public virtual ICollection<OrdenDeServicio> OrdenDeServicioidEnviadaNavigations { get; set; } = new List<OrdenDeServicio>();

    public virtual ICollection<PacienteOncologico> PacienteOncologicoidPacienteOncologicoNavigations { get; set; } = new List<PacienteOncologico>();

    public virtual ICollection<PacienteOncologico> PacienteOncologicoidRecibeQuimioNavigations { get; set; } = new List<PacienteOncologico>();

    public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();

    public virtual ICollection<Solicitud> SolicitudidGeneradaNavigations { get; set; } = new List<Solicitud>();

    public virtual ICollection<Solicitud> SolicitudidInterconsultaEnviadaNavigations { get; set; } = new List<Solicitud>();
}
