using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PropuestaPago
{
    public int Id { get; set; }

    public string? CodigoFactura { get; set; }

    public string? NroFactura { get; set; }

    public decimal TotalFactura { get; set; }

    public int? idProveedor { get; set; }

    public string? NroPropuesta { get; set; }

    public int? ClinicasId { get; set; }

    public virtual Clinica? Clinicas { get; set; }
}
