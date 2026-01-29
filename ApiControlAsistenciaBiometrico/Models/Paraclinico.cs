using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Paraclinico
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public int? idExamenesParaclinicos { get; set; }

    public string? Resultado { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual ExamenesParaclinico? idExamenesParaclinicosNavigation { get; set; }
}
