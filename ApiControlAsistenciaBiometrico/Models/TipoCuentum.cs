using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoCuentum
{
    public int Id { get; set; }

    public string CodigoTipo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int? UsuarioCreadorId { get; set; }

    public int? UsuarioModificadorId { get; set; }

    public DateTime? Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public int? ClinicasId { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual ICollection<CuentasContable> CuentasContables { get; set; } = new List<CuentasContable>();

    public virtual Usuario? UsuarioCreador { get; set; }

    public virtual Usuario? UsuarioModificador { get; set; }
}
