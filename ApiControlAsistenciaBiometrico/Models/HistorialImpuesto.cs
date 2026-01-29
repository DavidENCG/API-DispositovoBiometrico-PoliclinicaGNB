using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class HistorialImpuesto
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public int? ClinicaId { get; set; }

    public int? IdImpuesto { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public decimal? Valor { get; set; }
}
