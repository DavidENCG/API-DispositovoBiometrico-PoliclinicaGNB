using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class EstadoCuentum
{
    public int Id { get; set; }

    public string? CodigoFactura { get; set; }

    public string? NroFactura { get; set; }

    public decimal? TotalCompleto { get; set; }

    public int? idProveedor { get; set; }

    public int? ClinicasId { get; set; }

    public int? ClienteId { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Clinica? Clinicas { get; set; }
}
