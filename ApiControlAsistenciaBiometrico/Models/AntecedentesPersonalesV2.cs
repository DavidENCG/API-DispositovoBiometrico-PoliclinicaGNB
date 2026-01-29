using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesPersonalesV2
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public bool? Diabetes { get; set; }

    public bool? Hipertension { get; set; }

    public bool? Cardiacos { get; set; }

    public bool? Respiratoria { get; set; }

    public bool? Cancer { get; set; }

    public bool? DefectosGeneticos { get; set; }

    public bool? EnfermedadMental { get; set; }

    public bool? Osteoporosis { get; set; }

    public bool? Reumatica { get; set; }

    public bool? Convulsiones { get; set; }

    public bool? TrastornoHemorragico { get; set; }

    public bool? InfeccionesGraves { get; set; }

    public bool? EnfermedadRenal { get; set; }

    public bool? Otra { get; set; }

    public string? OtraDescripcion { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
