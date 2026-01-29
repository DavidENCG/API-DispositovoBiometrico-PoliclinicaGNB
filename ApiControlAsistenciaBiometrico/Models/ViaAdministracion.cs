using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ViaAdministracion
{
    public int Id { get; set; }

    public string? Via { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<IndicacionesTerapeutica> IndicacionesTerapeuticas { get; set; } = new List<IndicacionesTerapeutica>();

    public virtual ICollection<Unidosi> Unidosis { get; set; } = new List<Unidosi>();
}
