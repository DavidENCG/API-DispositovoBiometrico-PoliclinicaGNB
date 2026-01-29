using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ReservaEmergencium
{
    public int Id { get; set; }

    public int PacientesId { get; set; }

    public int? ServiciosId { get; set; }

    public int? ServicioDeEspacioId { get; set; }

    public DateTime FechaAgendada { get; set; }

    public string? TipoEmergencia { get; set; }

    public int? CantidadEmergencia { get; set; }

    public string? TipoTerapia { get; set; }

    public int? CantidadTerapia { get; set; }

    public int? QuiforanoHoras { get; set; }

    public bool EsAmbulatorio { get; set; }

    public string? Motivo { get; set; }

    public DateTime DateCreated { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<EstadiaPaciente> EstadiaPacientes { get; set; } = new List<EstadiaPaciente>();

    public virtual Paciente Pacientes { get; set; } = null!;

    public virtual ServicioDeEspacio? ServicioDeEspacio { get; set; }

    public virtual Servicio? Servicios { get; set; }
}
