using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoUnidadMedidum
{
    public int Id { get; set; }

    public string NombreTipo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<UnidadesMedida> UnidadesMedida { get; set; } = new List<UnidadesMedida>();
}
