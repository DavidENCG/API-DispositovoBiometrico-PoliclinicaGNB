using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesHabitosPsicobiologico
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public bool? idEjercicio { get; set; }

    public bool? idCafeina { get; set; }

    public bool? idCafeinaCola { get; set; }

    public int? CafeinaColaTazas { get; set; }

    public bool? idCafeinaTe { get; set; }

    public int? CafeinaTeTazas { get; set; }

    public bool? idCafeinaCafe { get; set; }

    public int? CafeinaCafeTazas { get; set; }

    public bool? idAlcohol { get; set; }

    public int? idFrecuenciaAlcohol { get; set; }

    public bool? idProblemasAlcohol { get; set; }

    public string? DescriProblemaAlcohol { get; set; }

    public bool? idDieta { get; set; }

    public bool? idDietaMedica { get; set; }

    public bool? idConsumoSal { get; set; }

    public bool? idConsumoGrasa { get; set; }

    public bool? idTabaco { get; set; }

    public DateTime? TabacoFechaInicio { get; set; }

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
