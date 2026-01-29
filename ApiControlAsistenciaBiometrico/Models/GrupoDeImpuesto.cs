using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class GrupoDeImpuesto
{
    public int Id { get; set; }

    public string? Grupo { get; set; }

    public string? Descripcion { get; set; }

    public int? ClinicasId { get; set; }

    public int? CuentaContableId { get; set; }

    public virtual Clinica? Clinicas { get; set; }

    public virtual ICollection<DefinicionGrupoImpuesto> DefinicionGrupoImpuestos { get; set; } = new List<DefinicionGrupoImpuesto>();
}
