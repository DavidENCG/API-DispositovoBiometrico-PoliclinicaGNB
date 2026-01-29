using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ImpuestosItem
{
    public int Id { get; set; }

    public int? idImpuesto { get; set; }

    public int? idItems { get; set; }

    public virtual Impuesto? idImpuestoNavigation { get; set; }

    public virtual Item? idItemsNavigation { get; set; }
}
