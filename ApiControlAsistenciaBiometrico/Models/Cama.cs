using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Cama
{
    public int Id { get; set; }

    public int? Habitacion_ID { get; set; }

    public string? Paciente_ID { get; set; }

    public string? Prefijo { get; set; }

    public string? Nombre { get; set; }

    public decimal? PrecioPorHora { get; set; }

    public decimal? PrecioPorDia { get; set; }

    public bool? Reservado { get; set; }

    public DateTime? Desde { get; set; }

    public DateTime? Hasta { get; set; }

    public bool? Activo { get; set; }

    public int? ServicioDeEspacioId { get; set; }

    public int? ClinicaId { get; set; }

    public string? CodigoInterno { get; set; }

    public int? NumeroCama { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<EstadiaPaciente> EstadiaPacientes { get; set; } = new List<EstadiaPaciente>();

    public virtual Habitacione? Habitacion { get; set; }

    public virtual ICollection<ProgramacionQuirurgica> ProgramacionQuirurgicas { get; set; } = new List<ProgramacionQuirurgica>();

    public virtual ICollection<ReservaHospitalizacion> ReservaHospitalizacions { get; set; } = new List<ReservaHospitalizacion>();

    public virtual ServicioDeEspacio? ServicioDeEspacio { get; set; }
}
