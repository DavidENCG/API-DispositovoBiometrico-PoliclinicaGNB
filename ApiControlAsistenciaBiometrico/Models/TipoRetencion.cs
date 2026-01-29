using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoRetencion
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<RetencionesFactura> RetencionesFacturas { get; set; } = new List<RetencionesFactura>();
}
