using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ProgramacionQuirurgica
{
    public int IdProgramacion { get; set; }

    public int IdPaciente { get; set; }

    public string NumeroCaso { get; set; } = null!;

    public string Motivo { get; set; } = null!;

    public DateTime FechaHoraInicio { get; set; }

    public DateTime? FechaHoraFin { get; set; }

    public int DuracionEstimada { get; set; }

    public int IdQuirofano { get; set; }

    public int? IdCamilla { get; set; }

    public string EstadoProgramacion { get; set; } = null!;

    public string? MedicoAsignado { get; set; }

    public int ClinicaId { get; set; }

    public bool Admitido { get; set; }

    public DateTime? FechaAdmision { get; set; }

    public int IdEstadoCirugia { get; set; }

    public virtual Clinica Clinica { get; set; } = null!;

    public virtual Cama? IdCamillaNavigation { get; set; }

    public virtual EstadoCirugium IdEstadoCirugiaNavigation { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;

    public virtual Habitacione IdQuirofanoNavigation { get; set; } = null!;
}
