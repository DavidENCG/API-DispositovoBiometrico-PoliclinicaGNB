using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class MotivoReagendum
{
    public int Id { get; set; }

    public string? CodigoCaso { get; set; }

    public DateTime? FechaPautada { get; set; }

    public DateTime? FechaNueva { get; set; }

    public string? Motivo { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
