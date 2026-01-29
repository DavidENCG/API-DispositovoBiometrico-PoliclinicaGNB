using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Honorario
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public string Moneda { get; set; } = null!;

    public int ClinicaId { get; set; }

    public int StatusUserId { get; set; }

    public int ProveedoresId { get; set; }

    public string? Codigo { get; set; }

    public virtual Clinica Clinica { get; set; } = null!;

    public virtual ICollection<HonorarioBaremo> HonorarioBaremos { get; set; } = new List<HonorarioBaremo>();

    public virtual ICollection<PresupuestoHonorario> PresupuestoHonorarios { get; set; } = new List<PresupuestoHonorario>();

    public virtual Proveedore Proveedores { get; set; } = null!;

    public virtual StatusUser StatusUser { get; set; } = null!;
}
