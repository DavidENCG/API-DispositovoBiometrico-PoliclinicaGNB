using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class NroNotaD
{
    public int Id { get; set; }

    public string NroNotaDebito { get; set; } = null!;

    public int ClinicaId { get; set; }
}
