using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class CuentasContable
{
    public int Id { get; set; }

    public string CodigoCuenta { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int TipoCuentaId { get; set; }

    public int JerarquiaCuentaId { get; set; }

    public bool Activo { get; set; }

    public int? UsuarioCreadorId { get; set; }

    public int? UsuarioModificadorId { get; set; }

    public DateTime? Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int? ClinicasId { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual JerarquiaCuentum JerarquiaCuenta { get; set; } = null!;

    public virtual ICollection<PlanContableCuenta> PlanContableCuenta { get; set; } = new List<PlanContableCuenta>();

    public virtual TipoCuentum TipoCuenta { get; set; } = null!;

    public virtual Usuario? UsuarioCreador { get; set; }

    public virtual Usuario? UsuarioModificador { get; set; }
}
