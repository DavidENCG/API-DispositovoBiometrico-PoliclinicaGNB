using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Piso
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Habitacione> Habitaciones { get; set; } = new List<Habitacione>();

    public virtual ICollection<ServiciosConfigurable> ServiciosConfigurables { get; set; } = new List<ServiciosConfigurable>();
}
