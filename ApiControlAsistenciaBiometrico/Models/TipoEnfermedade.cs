using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoEnfermedade
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<AntecedentesFamiliare> AntecedentesFamiliares { get; set; } = new List<AntecedentesFamiliare>();

    public virtual ICollection<AntecedentesFamiliares_HC> AntecedentesFamiliares_HCs { get; set; } = new List<AntecedentesFamiliares_HC>();

    public virtual Clinica? Clinica { get; set; }
}
