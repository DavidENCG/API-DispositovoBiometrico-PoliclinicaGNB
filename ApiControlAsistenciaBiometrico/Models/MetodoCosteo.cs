using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class MetodoCosteo
{
    public int Id { get; set; }

    public string NombreMetodo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
