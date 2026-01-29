using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class StatusPresupuesto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();
}
