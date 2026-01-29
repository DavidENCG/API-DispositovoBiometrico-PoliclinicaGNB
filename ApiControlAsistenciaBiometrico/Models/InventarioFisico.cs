using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class InventarioFisico
{
    public int Id { get; set; }

    public int InventarioId { get; set; }

    public int CantidadConteo { get; set; }

    public DateTime? FechaConteo { get; set; }

    public string? UsuarioRegistro { get; set; }

    public string? Comentarios { get; set; }

    public int? Diferencia { get; set; }

    public int? InventarioAlmacen { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Inventario Inventario { get; set; } = null!;
}
