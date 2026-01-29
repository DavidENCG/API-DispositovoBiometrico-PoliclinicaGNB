using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class NroControlServicio
{
    public int Id { get; set; }

    public int? Numero { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
