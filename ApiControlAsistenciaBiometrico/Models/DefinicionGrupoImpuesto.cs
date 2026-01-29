using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class DefinicionGrupoImpuesto
{
    public int Id { get; set; }

    public int? idGrupoImpuesto { get; set; }

    public int? idImpuesto { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? idRetencion { get; set; }

    public virtual GrupoDeImpuesto? idGrupoImpuestoNavigation { get; set; }

    public virtual Impuesto? idImpuestoNavigation { get; set; }

    public virtual Retencione? idRetencionNavigation { get; set; }
}
