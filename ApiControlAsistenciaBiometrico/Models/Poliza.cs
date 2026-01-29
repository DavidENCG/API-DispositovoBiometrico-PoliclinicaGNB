using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Poliza
{
    public int Id { get; set; }

    public string? CedulaPaciente { get; set; }

    public int? ClinicaId { get; set; }

    public int? ClienteId { get; set; }

    public int? Status { get; set; }

    public string? Cobertura { get; set; }

    public string? CodigoVerSeguro { get; set; }

    public string? CodigoVerCaso { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? NombrePoliza { get; set; }

    public int? ServicioId { get; set; }

    public int? SeguroPacientesId { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();

    public virtual SegurosPaciente? SeguroPacientes { get; set; }

    public virtual Servicio? Servicio { get; set; }
}
