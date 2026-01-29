using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Item
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? idCategoriaItems { get; set; }

    public int? idClientes { get; set; }

    public decimal? CostoParticular { get; set; }

    public decimal? CostoSeguro { get; set; }

    public int? idTipoIVA { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<CitasMedica> CitasMedicas { get; set; } = new List<CitasMedica>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<EstudiosDetalle> EstudiosDetalles { get; set; } = new List<EstudiosDetalle>();

    public virtual ICollection<ImpuestosItem> ImpuestosItems { get; set; } = new List<ImpuestosItem>();

    public virtual ICollection<ServicioDetalle> ServicioDetalles { get; set; } = new List<ServicioDetalle>();

    public virtual CategoriaItem? idCategoriaItemsNavigation { get; set; }

    public virtual Cliente? idClientesNavigation { get; set; }

    public virtual TipoIVA? idTipoIVANavigation { get; set; }
}
