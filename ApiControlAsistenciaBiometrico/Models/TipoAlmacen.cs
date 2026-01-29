using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoAlmacen
{
    public int Id { get; set; }

    public string NombreTipoAlmacen { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<Almacene> Almacenes { get; set; } = new List<Almacene>();

    public virtual Clinica? Clinica { get; set; }
}
