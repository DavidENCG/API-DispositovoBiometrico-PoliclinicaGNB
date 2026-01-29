using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PerfilesProveedore
{
    public int Id { get; set; }

    public int ClinicaId { get; set; }

    public int GrupoProveedorId { get; set; }

    public int CuentaContableId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }
}
