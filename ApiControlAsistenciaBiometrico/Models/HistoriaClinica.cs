using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class HistoriaClinica
{
    public int HistoriaClinicaId { get; set; }

    public int PacienteId { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public string? AntecedentesPersonales { get; set; }

    public string? AntecedentesFamiliares { get; set; }

    public string? HabitosPsicobiologicos { get; set; }

    public string? TA { get; set; }

    public string? FC { get; set; }

    public string? FR { get; set; }

    public string? Peso { get; set; }

    public string? Talla { get; set; }

    public string? IMC { get; set; }

    public string? SATO2 { get; set; }

    public string? Temperatura { get; set; }

    public string? Observaciones { get; set; }

    public string? ExamenesParaclinicos { get; set; }

    public string? Laboratorios { get; set; }

    public string? RXTorax { get; set; }

    public string? EKG { get; set; }

    public string? IDX { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente Paciente { get; set; } = null!;
}
