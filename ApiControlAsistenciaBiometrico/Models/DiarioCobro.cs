using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class DiarioCobro
{
    public int Id { get; set; }

    public string? CodigoFactura { get; set; }

    public string? NroFactura { get; set; }

    public decimal TotalFactura { get; set; }

    public int IdBanco { get; set; }

    public int IdMetodoPago { get; set; }

    public DateOnly FechaPago { get; set; }

    public string NroReferencia { get; set; } = null!;

    public DateTime? FechaTranscion { get; set; }

    public int? Moneda { get; set; }

    public string? Clasificacion { get; set; }

    public decimal? TotalDolares { get; set; }

    public decimal? Tasa { get; set; }

    public int? ClienteId { get; set; }

    public string? NroFacturaAfectada { get; set; }

    public bool Enlazado { get; set; }

    public int? NumeroCuenta { get; set; }

    public int? ClinicasId { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual MaestroCuenta IdBancoNavigation { get; set; } = null!;

    public virtual MetodoPago IdMetodoPagoNavigation { get; set; } = null!;
}
