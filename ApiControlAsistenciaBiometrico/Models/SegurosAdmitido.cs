using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class SegurosAdmitido
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
