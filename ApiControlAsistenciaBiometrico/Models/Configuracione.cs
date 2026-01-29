using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Configuracione
{
    public int Id { get; set; }

    public bool? TasaAutomatica { get; set; }

    public string? LogoReportes { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
