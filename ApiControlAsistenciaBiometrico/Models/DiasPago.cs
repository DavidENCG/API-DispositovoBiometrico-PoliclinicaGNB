using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class DiasPago
{
    public int Id { get; set; }

    public string? Dias { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
