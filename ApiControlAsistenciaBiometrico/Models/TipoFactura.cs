using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoFactura
{
    public string? Tipo { get; set; }

    public int id { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
