using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class HistorialConversionesUnidade
{
    public int Id { get; set; }

    public DateTime FechaHoraConversion { get; set; }

    public int UnidadMedidaOrigenId { get; set; }

    public decimal ValorEntrada { get; set; }

    public int UnidadMedidaDestinoId { get; set; }

    public decimal ResultadoConvertido { get; set; }

    public decimal? FactorUtilizado { get; set; }

    public int? ReglaConversionUnidadId { get; set; }

    public int? ProductoId { get; set; }

    public string? Observaciones { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Producto? Producto { get; set; }

    public virtual ReglasConversionUnidade? ReglaConversionUnidad { get; set; }

    public virtual UnidadesMedida UnidadMedidaDestino { get; set; } = null!;

    public virtual UnidadesMedida UnidadMedidaOrigen { get; set; } = null!;
}
