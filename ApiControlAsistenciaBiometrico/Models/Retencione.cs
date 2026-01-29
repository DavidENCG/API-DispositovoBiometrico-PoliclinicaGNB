using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Retencione
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public int? ClinicaId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public decimal? Minimo { get; set; }

    public decimal? Maximo { get; set; }

    public decimal Valor { get; set; }

    public virtual ICollection<DefinicionGrupoImpuesto> DefinicionGrupoImpuestos { get; set; } = new List<DefinicionGrupoImpuesto>();

    public virtual ICollection<RetencionesFactura> RetencionesFacturas { get; set; } = new List<RetencionesFactura>();
}
