using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Pasillo
{
    public int Id { get; set; }

    public int AlmacenId { get; set; }

    public string NombrePasillo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? ClinicaId { get; set; }

    public string? Codigo { get; set; }

    public virtual Almacene Almacen { get; set; } = null!;

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Ubicacione> Ubicaciones { get; set; } = new List<Ubicacione>();
}
