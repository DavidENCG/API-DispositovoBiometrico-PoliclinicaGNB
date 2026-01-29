using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class OrdenDeServicio
{
    public int Id { get; set; }

    public string? idOrdenServicio { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public int? idStatusOrden { get; set; }

    public int? idProveedor { get; set; }

    public decimal? TotalDivisas { get; set; }

    public decimal? TotalBs { get; set; }

    public string? Factura { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? ArchivoODS { get; set; }

    public int? idUsuario { get; set; }

    public DateTime? FechaFactura { get; set; }

    public int? idEnviada { get; set; }

    public string? token_recovery { get; set; }

    public int? idConfirmacionEntrega { get; set; }

    public decimal? TasaDeCambio { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual ResRapidum? idConfirmacionEntregaNavigation { get; set; }

    public virtual ResRapidum? idEnviadaNavigation { get; set; }

    public virtual Proveedore? idProveedorNavigation { get; set; }

    public virtual StatusOrden? idStatusOrdenNavigation { get; set; }

    public virtual Usuario? idUsuarioNavigation { get; set; }
}
