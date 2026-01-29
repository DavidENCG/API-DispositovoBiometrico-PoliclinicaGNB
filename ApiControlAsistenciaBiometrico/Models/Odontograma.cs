using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Odontograma
{
    public int Id { get; set; }

    public string? Json { get; set; }

    public string? ImageUrl { get; set; }

    public int? ClinicasId { get; set; }

    public int? ServiciosId { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual Servicio? Servicios { get; set; }
}
