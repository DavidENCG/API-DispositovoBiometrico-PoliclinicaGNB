using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class FormasPago
{
    public int Id { get; set; }

    public string? Forma { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<RegistroPago> RegistroPagos { get; set; } = new List<RegistroPago>();
}
