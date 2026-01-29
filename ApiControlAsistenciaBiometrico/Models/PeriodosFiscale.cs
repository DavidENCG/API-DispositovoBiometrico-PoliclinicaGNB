using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PeriodosFiscale
{
    public int Id { get; set; }

    public int Anio { get; set; }

    public int Mes { get; set; }

    public bool Activo { get; set; }

    public int ClinicasId { get; set; }

    public string CreadoPor { get; set; } = null!;

    public string? ModificadoPor { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual Clinica Clinicas { get; set; } = null!;
}
