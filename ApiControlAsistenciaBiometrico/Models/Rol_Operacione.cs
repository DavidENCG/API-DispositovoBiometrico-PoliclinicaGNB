using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Rol_Operacione
{
    public int Id { get; set; }

    public int? idRol { get; set; }

    public int? idOperaciones { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Operacione? idOperacionesNavigation { get; set; }

    public virtual Rol? idRolNavigation { get; set; }
}
