using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Turno
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? ClinicaId { get; set; }

    public virtual ICollection<AccionesPendientesEnfermerium> AccionesPendientesEnfermeria { get; set; } = new List<AccionesPendientesEnfermerium>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<InformeEnfermerium> InformeEnfermeria { get; set; } = new List<InformeEnfermerium>();
}
