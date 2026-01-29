using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesFamiliare
{
    public int Id { get; set; }

    public int? idParentesco { get; set; }

    public int? idGenero { get; set; }

    public bool? Vive { get; set; }

    public bool? Sano { get; set; }

    public int? Edad { get; set; }

    public int? idTipoEnfermedades { get; set; }

    public string? CausaMuerte { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Genero? idGeneroNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }

    public virtual Parentesco? idParentescoNavigation { get; set; }

    public virtual TipoEnfermedade? idTipoEnfermedadesNavigation { get; set; }
}
