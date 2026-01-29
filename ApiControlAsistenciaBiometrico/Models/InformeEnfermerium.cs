using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class InformeEnfermerium
{
    public int Id { get; set; }

    public int PacienteId { get; set; }

    public string? EnfermeraTurno { get; set; }

    public string? TurnoEnfermeria { get; set; }

    public string? NeuroTurno { get; set; }

    public string? RenalTurno { get; set; }

    public string? HemodTurno { get; set; }

    public string? PielMucosaTurno { get; set; }

    public string? HoraEgresoA { get; set; }

    public DateTime? FechaHoraEgreso { get; set; }

    public string? DietaPaciente { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public string? PrefijoDepartamento { get; set; }

    public string? idNroCaso { get; set; }

    public int? idTurnoPrincipal { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<AccionesPendientesEnfermerium> AccionesPendientesEnfermeria { get; set; } = new List<AccionesPendientesEnfermerium>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<EvolucionesEnfermerium> EvolucionesEnfermeria { get; set; } = new List<EvolucionesEnfermerium>();

    public virtual Paciente Paciente { get; set; } = null!;

    public virtual Turno? idTurnoPrincipalNavigation { get; set; }
}
