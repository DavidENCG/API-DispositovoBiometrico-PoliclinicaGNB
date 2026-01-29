using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Presupuesto
{
    public int Id { get; set; }

    public int? ServicioId { get; set; }

    public int? BaremoId { get; set; }

    public int SegurosPacientesId { get; set; }

    public decimal SubTotal { get; set; }

    public decimal Total { get; set; }

    public int StatusPresupuestoId { get; set; }

    public int ClinicaId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public DateTime? FechaAprobado { get; set; }

    public decimal? Deducible { get; set; }

    public int? PolizasId { get; set; }

    public bool Principal { get; set; }

    public string? Codigo { get; set; }

    public bool Cotizacion { get; set; }

    public bool UsoCirugia { get; set; }

    public virtual Clinica Clinica { get; set; } = null!;

    public virtual ICollection<DetallePresupuesto> DetallePresupuestos { get; set; } = new List<DetallePresupuesto>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Poliza? Polizas { get; set; }

    public virtual ICollection<PresupuestoHonorario> PresupuestoHonorarios { get; set; } = new List<PresupuestoHonorario>();

    public virtual ICollection<PresupuestoProducto> PresupuestoProductos { get; set; } = new List<PresupuestoProducto>();

    public virtual ICollection<PresupuestoServicioClinico> PresupuestoServicioClinicos { get; set; } = new List<PresupuestoServicioClinico>();

    public virtual ICollection<RegistroPago> RegistroPagos { get; set; } = new List<RegistroPago>();

    public virtual StatusPresupuesto StatusPresupuesto { get; set; } = null!;
}
