using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Factura
{
    public int Id { get; set; }

    public DateOnly? FechaFactura { get; set; }

    public string? CodigoFactura { get; set; }

    public string? NroFactura { get; set; }

    public decimal? TasaCambio { get; set; }

    public decimal? IVA { get; set; }

    public decimal? IGTF { get; set; }

    public decimal? TotalFactura { get; set; }

    public decimal? BaseImponible { get; set; }

    public string? Titular { get; set; }

    public string? CedulaTitular { get; set; }

    public string? Nota { get; set; }

    public int? idStatusFacturacion { get; set; }

    public int? IdProveedores { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? Descripcion { get; set; }

    public int? idTipoFactura { get; set; }

    public int? IdTipoDocumento { get; set; }

    public decimal? BaseImponibleExenta { get; set; }

    public string? NroFacturaAfectada { get; set; }

    public int? ClinicaId { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public DateTime? FechaOperacion { get; set; }

    public bool Enlazado { get; set; }

    public int? PresupuestoId { get; set; }

    public int? SegurosPacientesId { get; set; }

    public int? ClienteId { get; set; }

    public int? OrdenCompraId { get; set; }

    public bool? Conciliado { get; set; }

    public int? PacienteId { get; set; }

    public int? ServicioId { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Proveedore? IdProveedoresNavigation { get; set; }

    public virtual TipoDocumento? IdTipoDocumentoNavigation { get; set; }

    public virtual ICollection<ImpuestosFactura> ImpuestosFacturas { get; set; } = new List<ImpuestosFactura>();

    public virtual OrdenCompra? OrdenCompra { get; set; }

    public virtual Paciente? Paciente { get; set; }

    public virtual Presupuesto? Presupuesto { get; set; }

    public virtual ICollection<RetencionesFactura> RetencionesFacturas { get; set; } = new List<RetencionesFactura>();

    public virtual SegurosPaciente? SegurosPacientes { get; set; }

    public virtual Servicio? Servicio { get; set; }

    public virtual StatusFacturacion? idStatusFacturacionNavigation { get; set; }

    public virtual TipoFactura? idTipoFacturaNavigation { get; set; }
}
