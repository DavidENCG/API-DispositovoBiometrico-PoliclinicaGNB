using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class CostosEstadium
{
    public int Id { get; set; }

    public int CostoId { get; set; }

    public int EstadiaId { get; set; }

    public DateTime FechaCalculo { get; set; }

    public decimal HorasReales { get; set; }

    public decimal DiasReales { get; set; }

    public decimal PrecioHoraReferencia { get; set; }

    public decimal PrecioDiaReferencia { get; set; }

    public decimal CostoPorHoras { get; set; }

    public decimal CostoPorDias { get; set; }

    public decimal CostoCalculado { get; set; }

    public string ServicioOrigen { get; set; } = null!;

    public string VersionCalculo { get; set; } = null!;

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual EstadiaPaciente Estadia { get; set; } = null!;
}
