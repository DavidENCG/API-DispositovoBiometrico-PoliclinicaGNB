using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class EspecialidadesMedico
{
    public int Id { get; set; }

    public int? idMedico { get; set; }

    public int? idEspecialidad { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Especialidade? idEspecialidadNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
