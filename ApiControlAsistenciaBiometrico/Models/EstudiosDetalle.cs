using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class EstudiosDetalle
{
    public int Id { get; set; }

    public string? idCodigoEstudio { get; set; }

    public int? idCategoriaItems { get; set; }

    public int? idItems { get; set; }

    public int? idTipoRayosX { get; set; }

    public int? idCantidadProyeccionesRayosX { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Total { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual CantidadProyeccionesRayosX? idCantidadProyeccionesRayosXNavigation { get; set; }

    public virtual CategoriaItem? idCategoriaItemsNavigation { get; set; }

    public virtual Item? idItemsNavigation { get; set; }

    public virtual TipoRayosX? idTipoRayosXNavigation { get; set; }
}
