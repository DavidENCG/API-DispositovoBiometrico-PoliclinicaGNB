using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class OrdenCompraDetalle
{
    public int Id { get; set; }

    public int OrdenCompraId { get; set; }

    public int ProductoId { get; set; }

    public string? CodigoProducto { get; set; }

    public string NombreProducto { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public int UnidadesMedidasId { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? PctDescuento { get; set; }

    public decimal ImporteNeto { get; set; }

    public int ClinicasId { get; set; }

    public int? InventarioId { get; set; }

    public virtual Clinica Clinicas { get; set; } = null!;

    public virtual Inventario? Inventario { get; set; }

    public virtual OrdenCompra OrdenCompra { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;

    public virtual UnidadesMedida UnidadesMedidas { get; set; } = null!;
}
