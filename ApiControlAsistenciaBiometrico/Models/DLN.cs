using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class DLN
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<ExamenFisico2> ExamenFisico2s { get; set; } = new List<ExamenFisico2>();
}
