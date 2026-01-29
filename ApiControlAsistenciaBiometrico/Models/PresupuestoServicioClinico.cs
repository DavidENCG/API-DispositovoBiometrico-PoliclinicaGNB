using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PresupuestoServicioClinico
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int ServicioClinicoId { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Presupuesto Presupuesto { get; set; } = null!;

    public virtual ServicioClinico ServicioClinico { get; set; } = null!;
}
