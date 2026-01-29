using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ValoresSegmento
{
    public int Id { get; set; }

    public int ClinicasId { get; set; }

    public int SegmentoContableId { get; set; }

    public string Valor { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Activo { get; set; }

    public DateTime Creado { get; set; }

    public string CreadoPor { get; set; } = null!;

    public DateTime? Modificado { get; set; }

    public string? ModificadoPor { get; set; }
}
