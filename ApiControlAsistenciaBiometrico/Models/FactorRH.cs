using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class FactorRH
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<TipoDeSangre> TipoDeSangres { get; set; } = new List<TipoDeSangre>();
}
