using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class SeguroCasosEmergencium
{
    public int Id { get; set; }

    public string? idCaso { get; set; }

    public int? idPaciente { get; set; }

    public int? idSeguro { get; set; }

    public string? Poliza { get; set; }

    public string? OperadoraSeguro { get; set; }

    public string? CodigoValidacionSeguro { get; set; }

    public string? CodigoValidacionCaso { get; set; }

    public decimal? Deducible { get; set; }

    public decimal? MontoCobertura { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idPacienteNavigation { get; set; }

    public virtual Cliente? idSeguroNavigation { get; set; }
}
