using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Ciudad
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? idEstado { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();

    public virtual Estado? idEstadoNavigation { get; set; }
}
