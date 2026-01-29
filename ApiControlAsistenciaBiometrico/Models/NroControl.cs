using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class NroControl
{
    public int Id { get; set; }

    public string NroControl1 { get; set; } = null!;

    public int ClinicaId { get; set; }
}
