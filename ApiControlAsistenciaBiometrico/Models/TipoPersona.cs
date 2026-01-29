using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoPersona
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
