using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PlantillasMensaje
{
    public int Id { get; set; }

    public string? NombrePlantilla { get; set; }

    public string? Asunto { get; set; }

    public string? Mensaje { get; set; }

    public DateTime? DateCreated { get; set; }

    public bool? Predeterminada { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
