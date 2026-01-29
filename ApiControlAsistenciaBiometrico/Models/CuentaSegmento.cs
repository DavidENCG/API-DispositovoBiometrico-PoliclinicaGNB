using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class CuentaSegmento
{
    public int Id { get; set; }

    public int ClinicasId { get; set; }

    public int CuentaContableId { get; set; }

    public int SegmentoContableId { get; set; }

    public int ValorSegmentoId { get; set; }

    public DateTime Creado { get; set; }

    public string CreadoPor { get; set; } = null!;
}
