using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class DatosExcelString
{
    public int Id { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Referencia { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Monto { get; set; }

    public decimal? Saldo { get; set; }

    public string? TipoMovimiento { get; set; }

    public int? idBanco { get; set; }

    public int? ClinicasId { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual MaestroCuenta? idBancoNavigation { get; set; }
}
