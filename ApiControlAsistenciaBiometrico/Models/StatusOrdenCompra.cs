using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class StatusOrdenCompra
{
    public int Id { get; set; }

    public string NombreStatus { get; set; } = null!;

    public virtual ICollection<OrdenCompra> OrdenCompras { get; set; } = new List<OrdenCompra>();
}
