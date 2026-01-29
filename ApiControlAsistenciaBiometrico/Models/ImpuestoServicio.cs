using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ImpuestoServicio
{
    public int Id { get; set; }

    public decimal TotalImpuesto { get; set; }

    public int IdImpuesto { get; set; }

    public int IdServicio { get; set; }

    public string CodigoImpuesto { get; set; } = null!;

    public decimal? ValorImpuesto { get; set; }

    public virtual Impuesto IdImpuestoNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
