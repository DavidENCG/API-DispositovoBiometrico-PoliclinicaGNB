using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class BancoMonedum
{
    public int id { get; set; }

    public int idBanco { get; set; }

    public int idMoneda { get; set; }

    public virtual MaestroCuenta idBancoNavigation { get; set; } = null!;

    public virtual Monedum idMonedaNavigation { get; set; } = null!;
}
