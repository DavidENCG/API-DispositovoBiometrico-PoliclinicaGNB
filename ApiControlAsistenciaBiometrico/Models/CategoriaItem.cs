using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class CategoriaItem
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<EstudiosDetalle> EstudiosDetalles { get; set; } = new List<EstudiosDetalle>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();

    public virtual ICollection<ServicioDetalle> ServicioDetalles { get; set; } = new List<ServicioDetalle>();

    public virtual ICollection<pruebaitem> pruebaitems { get; set; } = new List<pruebaitem>();
}
