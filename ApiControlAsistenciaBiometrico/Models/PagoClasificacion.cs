using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PagoClasificacion
{
    public int Id { get; set; }

    public string Tipo { get; set; } = null!;
}
