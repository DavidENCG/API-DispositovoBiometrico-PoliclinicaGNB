using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Inventario
{
    public int Id { get; set; }

    public int ProductoId { get; set; }

    public int UbicacionId { get; set; }

    public int? LoteProductoId { get; set; }

    public int Cantidad { get; set; }

    public int? StockMinimo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? StockMaximo { get; set; }

    public decimal CostoPromedioUnitario { get; set; }

    public decimal ValorTotalInventario { get; set; }

    public int? ClinicaId { get; set; }

    public string? Codigo { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<InventarioFisico> InventarioFisicos { get; set; } = new List<InventarioFisico>();

    public virtual LotesProducto? LoteProducto { get; set; }

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalles { get; set; } = new List<OrdenCompraDetalle>();

    public virtual Producto Producto { get; set; } = null!;

    public virtual Ubicacione Ubicacion { get; set; } = null!;
}
