using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AsignacionesCuentasPrueba
{
    public int Id { get; set; }

    public int IdCuentaPrueba { get; set; }

    public string EmailSolicitanteReal { get; set; } = null!;

    public DateTime? FechaAsignacion { get; set; }

    public DateTime FechaExpiracion { get; set; }

    public int? ClinicaId { get; set; }

    public bool? TutorialVisto { get; set; }

    public bool? Activa { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Usuario IdCuentaPruebaNavigation { get; set; } = null!;
}
