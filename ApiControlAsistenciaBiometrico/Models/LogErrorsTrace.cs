using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class LogErrorsTrace
{
    public int Id { get; set; }

    public string? ErrorDescription { get; set; }

    public string? TraceDescription { get; set; }

    public int? ClinicaId { get; set; }

    public DateTime? DateCreated { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
