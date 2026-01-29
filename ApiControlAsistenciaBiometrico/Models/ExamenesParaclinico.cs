using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ExamenesParaclinico
{
    public int Id { get; set; }

    public string? Examen { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Paraclinico> Paraclinicos { get; set; } = new List<Paraclinico>();
}
