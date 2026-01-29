using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Examene
{
    public int Id { get; set; }

    public string? Examen { get; set; }

    public int? idTipoExamen { get; set; }

    public decimal? Precio { get; set; }

    public int? idTipoIVA { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();

    public virtual TipoExaman? idTipoExamenNavigation { get; set; }

    public virtual TipoIVA? idTipoIVANavigation { get; set; }
}
