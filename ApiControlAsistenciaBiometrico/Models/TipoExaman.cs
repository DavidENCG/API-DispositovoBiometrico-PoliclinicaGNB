using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoExaman
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Examene> Examenes { get; set; } = new List<Examene>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();
}
