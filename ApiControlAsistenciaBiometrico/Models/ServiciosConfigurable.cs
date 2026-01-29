using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ServiciosConfigurable
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public int? Piso_ID { get; set; }

    public string? PrefijoCaso_ID { get; set; }

    public string? CodigoFacturacion { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Piso? Piso { get; set; }
}
