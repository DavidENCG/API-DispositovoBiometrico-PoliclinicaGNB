using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class EstadoCirugium
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Color { get; set; }

    public virtual ICollection<ProgramacionQuirurgica> ProgramacionQuirurgicas { get; set; } = new List<ProgramacionQuirurgica>();
}
