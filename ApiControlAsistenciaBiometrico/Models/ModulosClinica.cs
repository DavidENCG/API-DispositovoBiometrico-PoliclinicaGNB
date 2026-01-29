using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ModulosClinica
{
    public int IdModulo { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Controller { get; set; }

    public string? Metodo { get; set; }

    public string? Area { get; set; }

    public string? Icono { get; set; }

    public bool EsSubMenu { get; set; }

    public int? IdModuloPadre { get; set; }

    public string Dependencia { get; set; } = null!;

    public bool Visible { get; set; }

    public int? Orden { get; set; }

    public virtual ICollection<AccesoClinicasModulo> AccesoClinicasModulos { get; set; } = new List<AccesoClinicasModulo>();

    public virtual ModulosClinica? IdModuloPadreNavigation { get; set; }

    public virtual ICollection<ModulosClinica> InverseIdModuloPadreNavigation { get; set; } = new List<ModulosClinica>();

    public virtual ICollection<Rol> Rols { get; set; } = new List<Rol>();
}
