using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ServicioDeEspacio
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Activo { get; set; }

    public DateTime? Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public string? Categoria { get; set; }

    public decimal? PrecioTotalPorDia { get; set; }

    public decimal? PrecioTotalPorHora { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<Cama> Camas { get; set; } = new List<Cama>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Habitacione> Habitaciones { get; set; } = new List<Habitacione>();

    public virtual ICollection<ReservaEmergencium> ReservaEmergencia { get; set; } = new List<ReservaEmergencium>();

    public virtual ICollection<ReservaHospitalizacion> ReservaHospitalizacions { get; set; } = new List<ReservaHospitalizacion>();
}
