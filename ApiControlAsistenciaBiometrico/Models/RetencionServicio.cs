using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class RetencionServicio
{
    public int Id { get; set; }

    public decimal MontoRetencion { get; set; }

    public int IdRetencion { get; set; }

    public string CodigoRetencion { get; set; } = null!;

    public decimal ValorRetencion { get; set; }

    public int IdServicio { get; set; }
}
