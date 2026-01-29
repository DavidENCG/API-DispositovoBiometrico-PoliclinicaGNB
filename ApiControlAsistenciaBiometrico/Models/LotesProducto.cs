using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class LotesProducto
{
    public int Id { get; set; }

    public int ProductoId { get; set; }

    public string NumeroLote { get; set; } = null!;

    public DateOnly FechaExpiracion { get; set; }

    public int UbicacionId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? ClinicaId { get; set; }

    public string? Codigo { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual Producto Producto { get; set; } = null!;

    public virtual Ubicacione Ubicacion { get; set; } = null!;
}
