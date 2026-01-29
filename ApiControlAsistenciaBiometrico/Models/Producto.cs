using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string NombreProducto { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int CategoriaId { get; set; }

    public int SubCategoriaId { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public string? Codigo { get; set; }

    public string? Imagen { get; set; }

    public int? UnidadMedidaCompraId { get; set; }

    public int? UnidadMedidaDespachoId { get; set; }

    public int? UnidadMedidaAlmacenamientoId { get; set; }

    public int? GrupoArticuloId { get; set; }

    public int? MetodoCosteoId { get; set; }

    public decimal? CostoUnitario { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Categorium Categoria { get; set; } = null!;

    public virtual Clinica? Clinica { get; set; }

    public virtual GrupoArticulo? GrupoArticulo { get; set; }

    public virtual ICollection<HistorialConversionesUnidade> HistorialConversionesUnidades { get; set; } = new List<HistorialConversionesUnidade>();

    public virtual ICollection<IndicacionesTerapeutica> IndicacionesTerapeuticas { get; set; } = new List<IndicacionesTerapeutica>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<LotesProducto> LotesProductos { get; set; } = new List<LotesProducto>();

    public virtual ICollection<MedicamentoFormula> MedicamentoFormulas { get; set; } = new List<MedicamentoFormula>();

    public virtual MetodoCosteo? MetodoCosteo { get; set; }

    public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalles { get; set; } = new List<OrdenCompraDetalle>();

    public virtual ICollection<PresupuestoProducto> PresupuestoProductos { get; set; } = new List<PresupuestoProducto>();

    public virtual ICollection<ProductoBaremo> ProductoBaremos { get; set; } = new List<ProductoBaremo>();

    public virtual ICollection<ReglasConversionUnidade> ReglasConversionUnidades { get; set; } = new List<ReglasConversionUnidade>();

    public virtual SubCategorium SubCategoria { get; set; } = null!;

    public virtual UnidadesMedida? UnidadMedidaAlmacenamiento { get; set; }

    public virtual UnidadesMedida? UnidadMedidaCompra { get; set; }

    public virtual UnidadesMedida? UnidadMedidaDespacho { get; set; }

    public virtual ICollection<Unidosi> Unidosis { get; set; } = new List<Unidosi>();
}
