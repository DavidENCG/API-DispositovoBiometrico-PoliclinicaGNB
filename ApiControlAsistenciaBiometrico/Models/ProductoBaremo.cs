using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ProductoBaremo
{
    public int Id { get; set; }

    public int ProductoId { get; set; }

    public int BaremoId { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Baremo Baremo { get; set; } = null!;

    public virtual Clinica? Clinica { get; set; }

    public virtual Producto Producto { get; set; } = null!;
}
