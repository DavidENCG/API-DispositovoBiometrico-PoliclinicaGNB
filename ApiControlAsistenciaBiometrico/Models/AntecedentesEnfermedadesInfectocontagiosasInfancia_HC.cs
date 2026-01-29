using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesEnfermedadesInfectocontagiosasInfancia_HC
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public bool? Sarampion { get; set; }

    public string? SarampionComplicacion { get; set; }

    public bool? SarampionTratamiento { get; set; }

    public bool? Varicela { get; set; }

    public string? VaricelaComplicacion { get; set; }

    public bool? VaricelaTratamiento { get; set; }

    public bool? Polio { get; set; }

    public string? PolioComplicacion { get; set; }

    public bool? PolioTratamiento { get; set; }

    public bool? Otra { get; set; }

    public string? OtraComplicacion { get; set; }

    public bool? OtraTratamiento { get; set; }

    public int? ClinicaId { get; set; }

    public bool? SarampionPresento { get; set; }

    public bool? VaricelaPresento { get; set; }

    public bool? PolioPresento { get; set; }

    public bool? OtraPresento { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
