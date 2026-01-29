using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ConfiguracionMonedum
{
    public int Id { get; set; }

    public int ClinicasId { get; set; }

    public string MonedaContabilidad { get; set; } = null!;

    public string MonedaReporteo { get; set; } = null!;

    public string? TipoCambioPredeterminado { get; set; }

    public string? CuentaPerdidaRealizada { get; set; }

    public string? CuentaUtilidadRealizada { get; set; }

    public string? CuentaPerdidaNoRealizada { get; set; }

    public string? CuentaUtilidadNoRealizada { get; set; }
}
