using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class FrecuenciaMenstruacion
{
    public int Id { get; set; }

    public string? Frecuencia { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<AntecedentesGinecobstetrico> AntecedentesGinecobstetricos { get; set; } = new List<AntecedentesGinecobstetrico>();

    public virtual ICollection<AntecedentesGinecobstetricos_HC> AntecedentesGinecobstetricos_HCs { get; set; } = new List<AntecedentesGinecobstetricos_HC>();

    public virtual Clinica? Clinica { get; set; }
}
