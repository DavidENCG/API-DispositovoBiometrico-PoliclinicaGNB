using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntMedicamentosActuale
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public string? idNroCaso { get; set; }

    public string? Medicamento { get; set; }

    public string? Dosis { get; set; }

    public string? Frecuencia { get; set; }

    public DateTime? FechaInicio { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }
}
