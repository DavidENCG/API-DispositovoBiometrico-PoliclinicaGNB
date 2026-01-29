using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Almacene
{
    public int Id { get; set; }

    public string NombreAlmacen { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? TipoAlmacenId { get; set; }

    public int? ClinicaId { get; set; }

    public string? Codigo { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Pasillo> Pasillos { get; set; } = new List<Pasillo>();

    public virtual TipoAlmacen? TipoAlmacen { get; set; }

    public virtual ICollection<Ubicacione> Ubicaciones { get; set; } = new List<Ubicacione>();
}
