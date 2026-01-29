using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoDocumentacion
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public virtual ICollection<MaestroCuenta> MaestroCuenta { get; set; } = new List<MaestroCuenta>();
}
