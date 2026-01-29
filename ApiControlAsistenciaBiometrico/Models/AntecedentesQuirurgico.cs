using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesQuirurgico
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public bool? Cirugia { get; set; }

    public string? Razon { get; set; }

    public DateTime? FechaCirugia { get; set; }

    public bool? idComplicacion { get; set; }

    public string? DescripcionComplicacion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }
}
