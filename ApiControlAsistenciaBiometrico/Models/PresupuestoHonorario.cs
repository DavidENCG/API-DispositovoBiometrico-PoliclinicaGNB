using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PresupuestoHonorario
{
    public int Id { get; set; }

    public int PresupuestoId { get; set; }

    public int HonorarioId { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Honorario Honorario { get; set; } = null!;

    public virtual Presupuesto Presupuesto { get; set; } = null!;
}
