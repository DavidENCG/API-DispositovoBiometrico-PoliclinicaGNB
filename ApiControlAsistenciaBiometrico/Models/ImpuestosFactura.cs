using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ImpuestosFactura
{
    public string CodigoFactura { get; set; } = null!;

    public int IdImpuesto { get; set; }

    public string CodigoImpuesto { get; set; } = null!;

    public decimal Monto { get; set; }

    public int? IdFactura { get; set; }

    public decimal? ValorImpuesto { get; set; }

    public int? ClinicasId { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;
}
