using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class MovimientoDePaciente
{
    public int MovimientoId { get; set; }

    public int PacienteId { get; set; }

    public DateTime MovimientoDateTime { get; set; }

    public string Departamento { get; set; } = null!;

    public string IdentificadorUbicacion { get; set; } = null!;

    public string Prefijo { get; set; } = null!;

    public string TipoDeMovimiento { get; set; } = null!;

    public string? Notas { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente Paciente { get; set; } = null!;
}
