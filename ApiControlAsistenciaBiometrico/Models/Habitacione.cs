using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Habitacione
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Piso_ID { get; set; }

    public int? ServicioDeEspacioId { get; set; }

    public string? Prefijo { get; set; }

    public decimal? PrecioPorDia { get; set; }

    public decimal? PrecioPorHora { get; set; }

    public bool? Reservado { get; set; }

    public DateTime? Desde { get; set; }

    public DateTime? Hasta { get; set; }

    public int? Servicio_ID { get; set; }

    public bool? Activo { get; set; }

    public int? ClinicaId { get; set; }

    public int? CantidadCamas { get; set; }

    public string? Ubicacion { get; set; }

    public virtual ICollection<Cama> Camas { get; set; } = new List<Cama>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<EstadiaPaciente> EstadiaPacientes { get; set; } = new List<EstadiaPaciente>();

    public virtual Piso? Piso { get; set; }

    public virtual ICollection<ProgramacionQuirurgica> ProgramacionQuirurgicas { get; set; } = new List<ProgramacionQuirurgica>();

    public virtual ServicioDeEspacio? ServicioDeEspacio { get; set; }
}
