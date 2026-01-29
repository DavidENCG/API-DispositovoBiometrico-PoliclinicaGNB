using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class InfoAlcohol
{
    public int Id { get; set; }

    public string? Info { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<AntecedentesHabitosPsicobiologico> AntecedentesHabitosPsicobiologicos { get; set; } = new List<AntecedentesHabitosPsicobiologico>();

    public virtual ICollection<AntecedentesHabitosPsicobiologicos_HC> AntecedentesHabitosPsicobiologicos_HCs { get; set; } = new List<AntecedentesHabitosPsicobiologicos_HC>();

    public virtual Clinica? Clinica { get; set; }
}
