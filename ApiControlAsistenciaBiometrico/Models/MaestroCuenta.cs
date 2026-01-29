using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class MaestroCuenta
{
    public int Id { get; set; }

    public string? Banco { get; set; }

    public string? NumeroCuenta { get; set; }

    public int TipoDocumento { get; set; }

    public string? NrDocumento { get; set; }

    public int? idTipoBanco { get; set; }

    public decimal? Saldo { get; set; }

    public int? CuentaPagos { get; set; }

    public int? ClinicasId { get; set; }

    public virtual ICollection<BancoMonedum> BancoMoneda { get; set; } = new List<BancoMonedum>();

    public virtual Clinica? Clinicas { get; set; }

    public virtual ICollection<DatosExcelString> DatosExcelStrings { get; set; } = new List<DatosExcelString>();

    public virtual ICollection<DiarioCobro> DiarioCobros { get; set; } = new List<DiarioCobro>();

    public virtual ICollection<DiarioPago> DiarioPagos { get; set; } = new List<DiarioPago>();

    public virtual TipoDocumentacion TipoDocumentoNavigation { get; set; } = null!;

    public virtual TipoBanco? idTipoBancoNavigation { get; set; }
}
