using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AsientosGenerale
{
    public int Id { get; set; }

    public int PlanContableCuentasId { get; set; }

    public decimal? Debito { get; set; }

    public decimal? Credito { get; set; }

    public string? DescripcionAsiento { get; set; }

    public int? IdTransOrigen { get; set; }

    public int ClinicasId { get; set; }

    public string CreadoPor { get; set; } = null!;

    public string? ModificadoPor { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual Clinica Clinicas { get; set; } = null!;

    public virtual PlanContableCuenta PlanContableCuentas { get; set; } = null!;
}
