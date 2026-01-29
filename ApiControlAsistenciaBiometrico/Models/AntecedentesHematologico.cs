using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesHematologico
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public DateTime? FechaTransfusion { get; set; }

    public int? CantidadTransfusion { get; set; }

    public bool? idComplicacion { get; set; }

    public string? DescripcionComplicacion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }
}
