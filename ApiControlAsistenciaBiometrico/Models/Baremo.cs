using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Baremo
{
    public int Id { get; set; }

    public string Motivo { get; set; } = null!;

    public int ClinicaId { get; set; }

    public int StatusUserId { get; set; }

    public int SeguroId { get; set; }

    public string? Codigo { get; set; }

    public virtual Clinica Clinica { get; set; } = null!;

    public virtual ICollection<HonorarioBaremo> HonorarioBaremos { get; set; } = new List<HonorarioBaremo>();

    public virtual ICollection<ProductoBaremo> ProductoBaremos { get; set; } = new List<ProductoBaremo>();

    public virtual Seguro Seguro { get; set; } = null!;

    public virtual ICollection<ServicioClinicoBaremo> ServicioClinicoBaremos { get; set; } = new List<ServicioClinicoBaremo>();

    public virtual StatusUser StatusUser { get; set; } = null!;
}
