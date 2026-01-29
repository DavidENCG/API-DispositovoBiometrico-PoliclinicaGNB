using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class BiometricoDispositivo
{
    public int Id { get; set; }

    public int? ClinicaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Serial { get; set; }

    public string? MarcaModelo { get; set; }

    public bool? Activo { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? UltimoSyncUtc { get; set; }

    public virtual ICollection<BiometricoMarcaje> BiometricoMarcajes { get; set; } = new List<BiometricoMarcaje>();

    public virtual ICollection<BiometricoSyncEstado> BiometricoSyncEstados { get; set; } = new List<BiometricoSyncEstado>();

    public virtual Clinica? Clinica { get; set; }
}
