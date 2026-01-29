using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ZonaExamenFisico
{
    public int Id { get; set; }

    public string? Zona { get; set; }

    public int? idExamen_ExamenFisico { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<ExamenFisico2> ExamenFisico2s { get; set; } = new List<ExamenFisico2>();

    public virtual Examenes_ExamenFisico? idExamen_ExamenFisicoNavigation { get; set; }
}
