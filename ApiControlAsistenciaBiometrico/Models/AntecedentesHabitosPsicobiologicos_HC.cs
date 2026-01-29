using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesHabitosPsicobiologicos_HC
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public bool? Ejercicio { get; set; }

    public bool? Cafeina { get; set; }

    public bool? CafeinaCola { get; set; }

    public int? CafeinaColaTazas { get; set; }

    public bool? CafeinaTe { get; set; }

    public int? CafeinaTeTazas { get; set; }

    public bool? CafeinaCafe { get; set; }

    public int? CafeinaCafeTazas { get; set; }

    public bool? Alcohol { get; set; }

    public int? idFrecuenciaAlcohol { get; set; }

    public bool? ProblemasAlcohol { get; set; }

    public string? DescripcionProblemasAlcohol { get; set; }

    public bool? Dieta { get; set; }

    public bool? DietaMedica { get; set; }

    public bool? ConsumoSal { get; set; }

    public bool? ConsumoGrasa { get; set; }

    public bool? Tabaco { get; set; }

    public DateTime? TabacoFechaIncio { get; set; }

    public int? TabacoCantidad { get; set; }

    public DateTime? TabacoFechaFin { get; set; }

    public bool? Drogas { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual InfoAlcohol? idFrecuenciaAlcoholNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
