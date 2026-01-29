using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class DetallePresupuesto
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int PresupuestoId { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Presupuesto Presupuesto { get; set; } = null!;
}
