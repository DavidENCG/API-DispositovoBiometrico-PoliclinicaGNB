using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Valore
{
    public int IdImpuestos { get; set; }

    public decimal? Valor { get; set; }

    public virtual Impuesto IdImpuestosNavigation { get; set; } = null!;
}
