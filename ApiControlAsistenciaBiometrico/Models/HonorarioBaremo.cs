using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class HonorarioBaremo
{
    public int Id { get; set; }

    public int HonorarioId { get; set; }

    public int BaremoId { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Baremo Baremo { get; set; } = null!;

    public virtual Clinica? Clinica { get; set; }

    public virtual Honorario Honorario { get; set; } = null!;
}
