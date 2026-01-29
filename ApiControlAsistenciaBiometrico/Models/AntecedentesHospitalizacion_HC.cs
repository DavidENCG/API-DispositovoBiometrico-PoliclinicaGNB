using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesHospitalizacion_HC
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public bool? Hospitalizacion { get; set; }

    public string? Razon { get; set; }

    public DateTime? FechaHospitalizacion { get; set; }

    public bool? Complicacion { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }
}
