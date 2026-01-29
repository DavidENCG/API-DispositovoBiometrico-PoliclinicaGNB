using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class UnidadesMedida
{
    public int Id { get; set; }

    public string NombreUnidad { get; set; } = null!;

    public string? Simbolo { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int? TipoUnidadMedidaId { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<HistorialConversionesUnidade> HistorialConversionesUnidadeUnidadMedidaDestinos { get; set; } = new List<HistorialConversionesUnidade>();

    public virtual ICollection<HistorialConversionesUnidade> HistorialConversionesUnidadeUnidadMedidaOrigens { get; set; } = new List<HistorialConversionesUnidade>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalles { get; set; } = new List<OrdenCompraDetalle>();

    public virtual ICollection<Producto> ProductoUnidadMedidaAlmacenamientos { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoUnidadMedidaCompras { get; set; } = new List<Producto>();

    public virtual ICollection<Producto> ProductoUnidadMedidaDespachos { get; set; } = new List<Producto>();

    public virtual ICollection<ReglasConversionUnidade> ReglasConversionUnidadeUnidadMedidaDestinos { get; set; } = new List<ReglasConversionUnidade>();

    public virtual ICollection<ReglasConversionUnidade> ReglasConversionUnidadeUnidadMedidaOrigens { get; set; } = new List<ReglasConversionUnidade>();

    public virtual TipoUnidadMedidum? TipoUnidadMedida { get; set; }
}
