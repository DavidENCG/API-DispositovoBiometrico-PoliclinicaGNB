using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Imagene
{
    public int Id { get; set; }

    public int? ServiciosId { get; set; }

    public string? UrlImagen { get; set; }

    public string? TituloImagen { get; set; }

    public virtual Servicio? Servicios { get; set; }
}
