using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class EstadiaPaciente
{
    public int EstadiaId { get; set; }

    public int PacienteId { get; set; }

    public string TipoEstadia { get; set; } = null!;

    public string? Departamento { get; set; }

    public int? HabitacionId { get; set; }

    public int? CamaId { get; set; }

    public DateTime FechaEntrada { get; set; }

    public DateTime? FechaSalida { get; set; }

    public bool? EsTransferencia { get; set; }

    public int? TransferenciaDesde { get; set; }

    public int? ReservaHospitalizacionId { get; set; }

    public int? ReservaEmergenciaId { get; set; }

    public decimal? PrecioCalculadoPorDia { get; set; }

    public decimal? PrecioCalculadoPorHora { get; set; }

    public decimal? TotalCalculado { get; set; }

    public string? Notas { get; set; }

    public string Estado { get; set; } = null!;

    public bool? Activo { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Cama? Cama { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<CostosEstadium> CostosEstadia { get; set; } = new List<CostosEstadium>();

    public virtual Habitacione? Habitacion { get; set; }

    public virtual ICollection<EstadiaPaciente> InverseTransferenciaDesdeNavigation { get; set; } = new List<EstadiaPaciente>();

    public virtual Paciente Paciente { get; set; } = null!;

    public virtual ReservaEmergencium? ReservaEmergencia { get; set; }

    public virtual ReservaHospitalizacion? ReservaHospitalizacion { get; set; }

    public virtual EstadiaPaciente? TransferenciaDesdeNavigation { get; set; }
}
