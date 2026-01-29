using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class NroFactura
{
    public int Id { get; set; }

    public int? Nro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
