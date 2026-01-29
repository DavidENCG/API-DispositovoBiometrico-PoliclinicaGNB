using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ReservaHospitalizacion
{
    public int Id { get; set; }

    public int ServicioId { get; set; }

    public int? ServicioEspacioId { get; set; }

    public int? CamaId { get; set; }

    public DateTime FechaAgendada { get; set; }

    public string TipoHospitalizacion { get; set; } = null!;

    public int CantidadHospitalizacion { get; set; }

    public int? QuirofanoHoras { get; set; }

    public string? TipoTerapia { get; set; }

    public int? CantidadTerapia { get; set; }

    public bool? EsAmbulatorio { get; set; }

    public string Motivo { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Cama? Cama { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<EstadiaPaciente> EstadiaPacientes { get; set; } = new List<EstadiaPaciente>();

    public virtual Servicio Servicio { get; set; } = null!;

    public virtual ServicioDeEspacio? ServicioEspacio { get; set; }
}
