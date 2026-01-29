using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Ubicacione
{
    public int Id { get; set; }

    public int AlmacenId { get; set; }

    public int PasilloId { get; set; }

    public string NombreUbicacion { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Almacene Almacen { get; set; } = null!;

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<LotesProducto> LotesProductos { get; set; } = new List<LotesProducto>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarioUbicacionEmisors { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarioUbicacionReceptors { get; set; } = new List<MovimientoInventario>();

    public virtual Pasillo Pasillo { get; set; } = null!;
}
