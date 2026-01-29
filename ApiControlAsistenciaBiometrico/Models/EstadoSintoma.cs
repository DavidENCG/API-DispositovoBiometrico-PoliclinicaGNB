using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class EstadoSintoma
{
    public int Id { get; set; }

    public string? Estado { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<HistoriaOcupacional> HistoriaOcupacionals { get; set; } = new List<HistoriaOcupacional>();
}
