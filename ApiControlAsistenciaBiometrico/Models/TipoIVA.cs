using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoIVA
{
    public int Id { get; set; }

    public string? Tipo { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Especialidade> Especialidades { get; set; } = new List<Especialidade>();

    public virtual ICollection<Examene> Examenes { get; set; } = new List<Examene>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<pruebaitem> pruebaitems { get; set; } = new List<pruebaitem>();
}
