using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Estado
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
