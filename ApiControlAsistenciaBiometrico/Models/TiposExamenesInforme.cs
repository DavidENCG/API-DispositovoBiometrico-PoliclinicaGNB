using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TiposExamenesInforme
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? ClinicaId { get; set; }

    public virtual ICollection<AccionesPendientesEnfermerium> AccionesPendientesEnfermeria { get; set; } = new List<AccionesPendientesEnfermerium>();

    public virtual Clinica? Clinica { get; set; }
}
