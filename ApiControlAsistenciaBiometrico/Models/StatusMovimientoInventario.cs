using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class StatusMovimientoInventario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();
}
