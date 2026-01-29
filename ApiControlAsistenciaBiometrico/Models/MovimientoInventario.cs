using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class MovimientoInventario
{
    public int Id { get; set; }

    public int InventarioId { get; set; }

    public int TipoMovimientoId { get; set; }

    public int Cantidad { get; set; }

    public int UnidadMedidaId { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string? UsuarioRegistro { get; set; }

    public string? Comentarios { get; set; }

    public int? UbicacionEmisorId { get; set; }

    public int? UbicacionReceptorId { get; set; }

    public int StatusMovimientoId { get; set; }

    public decimal? CostoUnitarioMovimiento { get; set; }

    public decimal? CostoTotalMovimiento { get; set; }

    public decimal? ValorInventarioAlFinalMovimiento { get; set; }

    public decimal? PrecioUnitarioMovimiento { get; set; }

    public decimal? PrecioTotalMovimiento { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Inventario Inventario { get; set; } = null!;

    public virtual StatusMovimientoInventario StatusMovimiento { get; set; } = null!;

    public virtual TipoMovimiento TipoMovimiento { get; set; } = null!;

    public virtual Ubicacione? UbicacionEmisor { get; set; }

    public virtual Ubicacione? UbicacionReceptor { get; set; }

    public virtual UnidadesMedida UnidadMedida { get; set; } = null!;
}
