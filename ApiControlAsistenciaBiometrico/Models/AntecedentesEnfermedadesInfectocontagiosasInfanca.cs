using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesEnfermedadesInfectocontagiosasInfanca
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public bool? idSarampion { get; set; }

    public string? SarampionComplicacion { get; set; }

    public bool? idSarampionTratamiento { get; set; }

    public bool? idVaricela { get; set; }

    public string? VaricelaComplicacion { get; set; }

    public bool? idVaricelaTratamiento { get; set; }

    public bool? idPolio { get; set; }

    public string? PolioComplicacion { get; set; }

    public bool? idPolioTratamiento { get; set; }

    public bool? idOtra { get; set; }

    public string? OtraComplicacion { get; set; }

    public bool? idOtraTratamiento { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
