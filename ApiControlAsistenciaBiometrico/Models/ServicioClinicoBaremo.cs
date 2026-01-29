using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ServicioClinicoBaremo
{
    public int Id { get; set; }

    public int ServicioClinicoId { get; set; }

    public int BaremoId { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Baremo Baremo { get; set; } = null!;

    public virtual Clinica? Clinica { get; set; }

    public virtual ServicioClinico ServicioClinico { get; set; } = null!;
}
