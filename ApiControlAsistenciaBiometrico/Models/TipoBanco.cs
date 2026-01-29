using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoBanco
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<MaestroCuenta> MaestroCuenta { get; set; } = new List<MaestroCuenta>();
}
