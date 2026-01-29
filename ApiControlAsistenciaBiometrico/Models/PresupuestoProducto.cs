using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PresupuestoProducto
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int ProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Presupuesto Presupuesto { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
