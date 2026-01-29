using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class CantidadProyeccionesRayosX
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<EstudiosDetalle> EstudiosDetalles { get; set; } = new List<EstudiosDetalle>();
}
