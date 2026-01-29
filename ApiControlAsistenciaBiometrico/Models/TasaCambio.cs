using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TasaCambio
{
    public int Id { get; set; }

    public decimal? Tasa { get; set; }

    public DateTime? DateUpdate { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
