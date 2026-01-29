using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ImpuestosRetencione
{
    public int Id { get; set; }

    public int? idImpuestos { get; set; }

    public int? idRetenciones { get; set; }

    public string CodigoImpuesto { get; set; } = null!;
}
