using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class EvolucionesEnfermerium
{
    public int Id { get; set; }

    public int InformeEnfermeriaId { get; set; }

    public string NombreEnfermera { get; set; } = null!;

    public string Notas { get; set; } = null!;

    public DateTime FechaHoraRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual InformeEnfermerium InformeEnfermeria { get; set; } = null!;
}
