using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class pruebaitem
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? idCategoriaItems { get; set; }

    public int? idClientes { get; set; }

    public decimal? CostoParticular { get; set; }

    public decimal? CostoSeguro { get; set; }

    public int? idTipoIVA { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual CategoriaItem? idCategoriaItemsNavigation { get; set; }

    public virtual Cliente? idClientesNavigation { get; set; }

    public virtual TipoIVA? idTipoIVANavigation { get; set; }
}
