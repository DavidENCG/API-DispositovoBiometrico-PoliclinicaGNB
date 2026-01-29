using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ReglasConversionUnidade
{
    public int Id { get; set; }

    public int UnidadMedidaOrigenId { get; set; }

    public int UnidadMedidaDestinoId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public decimal Numerador { get; set; }

    public decimal Denominador { get; set; }

    public int? ProductoId { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<HistorialConversionesUnidade> HistorialConversionesUnidades { get; set; } = new List<HistorialConversionesUnidade>();

    public virtual Producto? Producto { get; set; }

    public virtual UnidadesMedida UnidadMedidaDestino { get; set; } = null!;

    public virtual UnidadesMedida UnidadMedidaOrigen { get; set; } = null!;
}
