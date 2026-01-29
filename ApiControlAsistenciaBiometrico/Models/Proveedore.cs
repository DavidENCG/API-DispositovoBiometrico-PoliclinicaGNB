using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Proveedore
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Rif { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? TelefonoMovil { get; set; }

    public string? Fax { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? DireccionWeb { get; set; }

    public int? idClasificacionProveedor { get; set; }

    public int? idCondicionesConvenio { get; set; }

    public string? CuentaBancaria { get; set; }

    public int? idFormaPago { get; set; }

    public int? idMoneda { get; set; }

    public string? LimiteCredito { get; set; }

    public int? idDiaPago { get; set; }

    public int? idEstado { get; set; }

    public int? idCiudad { get; set; }

    public string? Especialidad { get; set; }

    public string? SubEspecialidad { get; set; }

    public string? Cadena { get; set; }

    public string? Observaciones { get; set; }

    public int? idTipoPersona { get; set; }

    public string? TipoConvenio { get; set; }

    public int? idCategoriaItems { get; set; }

    public int? ClinicaId { get; set; }

    public decimal? PrecioCaso { get; set; }

    public string? CuentaProveedor { get; set; }

    public int? GrupoProveedorId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<DiarioPago> DiarioPagos { get; set; } = new List<DiarioPago>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Honorario> Honorarios { get; set; } = new List<Honorario>();

    public virtual ICollection<OrdenCompra> OrdenCompras { get; set; } = new List<OrdenCompra>();

    public virtual ICollection<OrdenDeServicio> OrdenDeServicios { get; set; } = new List<OrdenDeServicio>();

    public virtual ICollection<ServicioDetalle> ServicioDetalles { get; set; } = new List<ServicioDetalle>();

    public virtual ICollection<ServiciosProveedore> ServiciosProveedores { get; set; } = new List<ServiciosProveedore>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual CategoriaItem? idCategoriaItemsNavigation { get; set; }

    public virtual Ciudad? idCiudadNavigation { get; set; }

    public virtual ClasificacionProveedor? idClasificacionProveedorNavigation { get; set; }

    public virtual CondicionesProveedor? idCondicionesConvenioNavigation { get; set; }

    public virtual DiasPago? idDiaPagoNavigation { get; set; }

    public virtual Estado? idEstadoNavigation { get; set; }

    public virtual FormaPago? idFormaPagoNavigation { get; set; }

    public virtual Monedum? idMonedaNavigation { get; set; }

    public virtual TipoPersona? idTipoPersonaNavigation { get; set; }
}
