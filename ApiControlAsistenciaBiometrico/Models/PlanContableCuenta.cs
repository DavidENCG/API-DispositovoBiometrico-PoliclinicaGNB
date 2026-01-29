using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class PlanContableCuenta
{
    public int Id { get; set; }

    public int PlanContableId { get; set; }

    public int CuentasContableId { get; set; }

    public int? UsuarioCreadorId { get; set; }

    public int? UsuarioModificadorId { get; set; }

    public DateTime? Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int? ClinicasId { get; set; }

    public virtual ICollection<AsientosGenerale> AsientosGenerales { get; set; } = new List<AsientosGenerale>();

    public virtual Clinica? Clinicas { get; set; }

    public virtual CuentasContable CuentasContable { get; set; } = null!;

    public virtual ICollection<DiarioAsientoManualesLinea> DiarioAsientoManualesLineas { get; set; } = new List<DiarioAsientoManualesLinea>();

    public virtual PlanContable PlanContable { get; set; } = null!;

    public virtual Usuario? UsuarioCreador { get; set; }

    public virtual Usuario? UsuarioModificador { get; set; }
}
