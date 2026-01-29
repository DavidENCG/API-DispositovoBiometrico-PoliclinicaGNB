using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Examenes_ExamenFisico
{
    public int Id { get; set; }

    public string? Examen { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<ExamenFisico2> ExamenFisico2s { get; set; } = new List<ExamenFisico2>();

    public virtual ICollection<ZonaExamenFisico> ZonaExamenFisicos { get; set; } = new List<ZonaExamenFisico>();
}
