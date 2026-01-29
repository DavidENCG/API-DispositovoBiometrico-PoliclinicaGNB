using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class LineasServicio
{
    public int Id { get; set; }

    public int? idItems { get; set; }

    public int? idCategoriaItems { get; set; }

    public int? idMedico { get; set; }

    public int? idMotivoConsulta { get; set; }

    public int? idEspecilidad { get; set; }

    public int? idProveedor { get; set; }

    public decimal? Costo { get; set; }

    public int? cantidad { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }
}
