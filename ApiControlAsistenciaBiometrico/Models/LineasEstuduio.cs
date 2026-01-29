using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class LineasEstuduio
{
    public int Id { get; set; }

    public string? idCategoriaItems { get; set; }

    public string? idItems { get; set; }

    public decimal? Costo { get; set; }

    public string? Proyecciones { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
