using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Operacione
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? idModulos { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Rol_Operacione> Rol_Operaciones { get; set; } = new List<Rol_Operacione>();

    public virtual Modulo? idModulosNavigation { get; set; }
}
