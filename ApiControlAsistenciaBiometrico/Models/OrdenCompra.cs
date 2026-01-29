using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class OrdenCompra
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public int ProviderId { get; set; }

    public string Contacto { get; set; } = null!;

    public string DireccionEntrega { get; set; } = null!;

    public int MonedaId { get; set; }

    public DateOnly FechaEntrega { get; set; }

    public int? ClinicasId { get; set; }

    public int? StatusOrdenCompraId { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Monedum Moneda { get; set; } = null!;

    public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalles { get; set; } = new List<OrdenCompraDetalle>();

    public virtual Proveedore Provider { get; set; } = null!;

    public virtual StatusOrdenCompra? StatusOrdenCompra { get; set; }
}
