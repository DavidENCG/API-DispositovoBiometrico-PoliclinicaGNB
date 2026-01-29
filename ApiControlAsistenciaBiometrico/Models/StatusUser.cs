using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class StatusUser
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<Baremo> Baremos { get; set; } = new List<Baremo>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Honorario> Honorarios { get; set; } = new List<Honorario>();

    public virtual ICollection<ServicioClinico> ServicioClinicos { get; set; } = new List<ServicioClinico>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
