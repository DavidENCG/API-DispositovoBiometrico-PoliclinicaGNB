using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class SegmentosContable
{
    public int Id { get; set; }

    public int ClinicasId { get; set; }

    public int EstructuraContableId { get; set; }

    public string Nombre { get; set; } = null!;

    public string CodigoSegmento { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Longitud { get; set; }

    public int Orden { get; set; }

    public bool Obligatorio { get; set; }

    public bool Activo { get; set; }

    public DateTime Creado { get; set; }

    public string CreadoPor { get; set; } = null!;

    public DateTime? Modificado { get; set; }

    public string? ModificadoPor { get; set; }
}
