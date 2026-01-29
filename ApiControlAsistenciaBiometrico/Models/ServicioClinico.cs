using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ServicioClinico
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int StatusUserId { get; set; }

    public decimal Precio { get; set; }

    public string Moneda { get; set; } = null!;

    public int? Cantidad { get; set; }

    public int ClinicasId { get; set; }

    public int? PacienteId { get; set; }

    public string? NroCaso { get; set; }

    public string? Codigo { get; set; }

    public virtual Clinica Clinicas { get; set; } = null!;

    public virtual ICollection<PresupuestoServicioClinico> PresupuestoServicioClinicos { get; set; } = new List<PresupuestoServicioClinico>();

    public virtual ICollection<ServicioClinicoBaremo> ServicioClinicoBaremos { get; set; } = new List<ServicioClinicoBaremo>();

    public virtual StatusUser StatusUser { get; set; } = null!;
}
