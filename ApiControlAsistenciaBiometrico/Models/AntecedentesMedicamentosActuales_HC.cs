using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesMedicamentosActuales_HC
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? CodigoCaso { get; set; }

    public string? Medicamento { get; set; }

    public string? Dosis { get; set; }

    public string? Frecuencia { get; set; }

    public string? FechaInicio { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }
}
