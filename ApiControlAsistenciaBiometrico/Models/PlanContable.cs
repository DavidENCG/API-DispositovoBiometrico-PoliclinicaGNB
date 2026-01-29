using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PlanContable
{
    public int Id { get; set; }

    public string CodigoPlan { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public bool? Activo { get; set; }

    public int? UsuarioCreadorId { get; set; }

    public int? UsuarioModificadorId { get; set; }

    public DateTime? Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int? ClinicasId { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual ICollection<PlanContableCuenta> PlanContableCuenta { get; set; } = new List<PlanContableCuenta>();

    public virtual Usuario? UsuarioCreador { get; set; }

    public virtual Usuario? UsuarioModificador { get; set; }
}
