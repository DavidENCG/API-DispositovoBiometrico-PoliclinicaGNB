using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AccesoClinicasModulo
{
    public int IdAcceso { get; set; }

    public int ClinicaId { get; set; }

    public int IdModulo { get; set; }

    public bool Visible { get; set; }

    public virtual Clinica Clinica { get; set; } = null!;

    public virtual ModulosClinica IdModuloNavigation { get; set; } = null!;
}
