using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AccionesPendientesEnfermerium
{
    public int Id { get; set; }

    public int InformeEnfermeriaId { get; set; }

    public string? Turno { get; set; }

    public string? Examen { get; set; }

    public string? Descripcion { get; set; }

    public int? idTurno { get; set; }

    public int? idExamen { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual InformeEnfermerium InformeEnfermeria { get; set; } = null!;

    public virtual TiposExamenesInforme? idExamenNavigation { get; set; }

    public virtual Turno? idTurnoNavigation { get; set; }
}
