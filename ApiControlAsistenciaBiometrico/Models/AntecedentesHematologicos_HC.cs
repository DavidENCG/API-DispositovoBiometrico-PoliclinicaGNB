using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesHematologicos_HC
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public DateTime? FechaTransfusion { get; set; }

    public int? CantidadTransfusion { get; set; }

    public bool? Complicacion { get; set; }

    public string? DescripcionComplicacion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }
}
