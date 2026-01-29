using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ValoresImpuesto
{
    public int Id { get; set; }

    public int? idImpuesto { get; set; }

    public decimal? Valor { get; set; }

    public virtual Impuesto? idImpuestoNavigation { get; set; }
}
