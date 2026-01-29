using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class RetencionesFactura
{
    public int Id { get; set; }

    public string CodigoFactura { get; set; } = null!;

    public int IdRetencion { get; set; }

    public string CodigoRetencion { get; set; } = null!;

    public decimal Monto { get; set; }

    public int? IdTipoRetencion { get; set; }

    public int? IdFactura { get; set; }

    public decimal? ValorRetencion { get; set; }

    public int? ClinicasId { get; set; }

    public string? NroComprobante { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual Factura? IdFacturaNavigation { get; set; }

    public virtual Retencione IdRetencionNavigation { get; set; } = null!;

    public virtual TipoRetencion? IdTipoRetencionNavigation { get; set; }
}
