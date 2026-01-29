using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class MedicamentoFormula
{
    public int Id { get; set; }

    public int FormulaId { get; set; }

    public int ProductoId { get; set; }

    public string Dosis { get; set; } = null!;

    public virtual Unidosi Formula { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
