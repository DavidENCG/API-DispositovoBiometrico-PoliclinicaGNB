using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class MetodoPago
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<DiarioCobro> DiarioCobros { get; set; } = new List<DiarioCobro>();

    public virtual ICollection<DiarioPago> DiarioPagos { get; set; } = new List<DiarioPago>();
}
