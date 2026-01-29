using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Rol
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Rol_Operacione> Rol_Operaciones { get; set; } = new List<Rol_Operacione>();

    public virtual ICollection<UsuarioClinica> UsuarioClinicas { get; set; } = new List<UsuarioClinica>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<ModulosClinica> Modulos { get; set; } = new List<ModulosClinica>();
}
