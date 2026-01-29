using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Impuesto
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public int? ClinicaId { get; set; }

    public int? IVA { get; set; }

    public int? IGTF { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public int TipoImpuesto { get; set; }

    public decimal? Minimo { get; set; }

    public decimal? Maximo { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<DefinicionGrupoImpuesto> DefinicionGrupoImpuestos { get; set; } = new List<DefinicionGrupoImpuesto>();

    public virtual ICollection<ImpuestoServicio> ImpuestoServicios { get; set; } = new List<ImpuestoServicio>();

    public virtual ICollection<ImpuestosFactura> ImpuestosFacturas { get; set; } = new List<ImpuestosFactura>();

    public virtual ICollection<ImpuestosItem> ImpuestosItems { get; set; } = new List<ImpuestosItem>();

    public virtual ICollection<ValoresImpuesto> ValoresImpuestos { get; set; } = new List<ValoresImpuesto>();
}
