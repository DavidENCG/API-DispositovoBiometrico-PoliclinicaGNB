using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class BiometricoSyncEstado
{
    public int Id { get; set; }

    public int? ClinicaId { get; set; }

    public int? DispositivoId { get; set; }

    public string AgentKey { get; set; } = null!;

    public DateTime? UltimoMarcajeUtc { get; set; }

    public DateTime? UltimoPullUtc { get; set; }

    public DateTime? UltimoPushUtc { get; set; }

    public DateTime CreadoUtc { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual BiometricoDispositivo? Dispositivo { get; set; }
}
