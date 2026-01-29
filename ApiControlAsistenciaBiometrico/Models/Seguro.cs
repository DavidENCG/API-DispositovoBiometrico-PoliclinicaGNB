using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Seguro
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<Baremo> Baremos { get; set; } = new List<Baremo>();

    public virtual Clinica? Clinica { get; set; }
}
