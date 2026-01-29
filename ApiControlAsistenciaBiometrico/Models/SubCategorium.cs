using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class SubCategorium
{
    public int Id { get; set; }

    public int CategoriaId { get; set; }

    public string NombreSubCategoria { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Categorium Categoria { get; set; } = null!;

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
