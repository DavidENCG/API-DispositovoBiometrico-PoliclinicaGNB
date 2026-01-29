using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class NroNotaC
{
    public int Id { get; set; }

    public string NroNotaCredito { get; set; } = null!;

    public int ClinicaId { get; set; }
}
