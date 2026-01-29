using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class SegurosPaciente
{
    public int Id { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? ParentescoConPaciente { get; set; }

    public string? Cedula { get; set; }

    public string? DireccionHabitacion { get; set; }

    public string? Empresa { get; set; }

    public string? DireccionTrabajo { get; set; }

    public string? TelefonoTrabajo { get; set; }

    public string? TelefonoHabitacion { get; set; }

    public string? TelefonoCelular { get; set; }

    public int? idPacientes { get; set; }

    public int? ClinicaId { get; set; }

    public int? ClienteId { get; set; }

    public int? TipoClienteId { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Poliza> Polizas { get; set; } = new List<Poliza>();

    public virtual TipoCliente? TipoCliente { get; set; }

    public virtual Paciente? idPacientesNavigation { get; set; }
}
