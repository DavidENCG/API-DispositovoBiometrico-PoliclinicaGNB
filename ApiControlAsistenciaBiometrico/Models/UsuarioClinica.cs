using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class UsuarioClinica
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public int ClinicaId { get; set; }

    public int RolId { get; set; }

    public virtual Clinica Clinica { get; set; } = null!;

    public virtual Rol Rol { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
