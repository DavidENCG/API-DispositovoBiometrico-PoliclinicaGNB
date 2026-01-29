using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class HistoriaMotivo
{
    public int Id { get; set; }

    public string? CodigoCita { get; set; }

    public string? MotivoConsulta { get; set; }

    public string? EnfermedadActual { get; set; }

    public string? RecomendacionesMedicas { get; set; }

    public DateTime Fecha { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
