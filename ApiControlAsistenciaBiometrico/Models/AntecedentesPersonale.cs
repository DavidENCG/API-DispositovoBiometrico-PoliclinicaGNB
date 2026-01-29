using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesPersonale
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public bool? idDiabetes { get; set; }

    public string? DiabetesTiempoEvolucion { get; set; }

    public bool? idDiabetesTratamiento { get; set; }

    public bool? idHipertension { get; set; }

    public string? HipertensionTiempoEvolicion { get; set; }

    public bool? idHipertensionTratamiento { get; set; }

    public bool? idCardiaca { get; set; }

    public string? CardiacaTiempoEvolucion { get; set; }

    public bool? idCardiacaTratamiento { get; set; }

    public bool? idRespiratoria { get; set; }

    public string? RespiratoriaTiempoEvolucion { get; set; }

    public bool? idRespiratoriaTratamiento { get; set; }

    public bool? idCancer { get; set; }

    public string? CancerTiempoEvolucion { get; set; }

    public bool? idCancerTratamiento { get; set; }

    public bool? idDefectosGeneticos { get; set; }

    public string? DefectosGeneticosTiempoEvolucion { get; set; }

    public bool? idDefectosGeneticosTratamiento { get; set; }

    public bool? idEnferemedadMental { get; set; }

    public string? EnferemedadMentalTiempoEvolucion { get; set; }

    public bool? idEnfermedadMentalTratamiento { get; set; }

    public bool? idOsteoporosis { get; set; }

    public string? OsteoporosisTiempoEvolucion { get; set; }

    public bool? idOsteoporosisTratamiento { get; set; }

    public bool? idReumatica { get; set; }

    public string? ReumaticaTiempoEvolucion { get; set; }

    public bool? idReumaticaTratamiento { get; set; }

    public bool? idConvulsiones { get; set; }

    public string? ConvulsionesTiempoEvolcion { get; set; }

    public bool? idConvulsionesTratamiento { get; set; }

    public bool? idTrastornoHemorragico { get; set; }

    public string? TrastornoHemorragicoTiempoEvolucion { get; set; }

    public bool? idTrastornoHemorragicoTratamiento { get; set; }

    public bool? idInfeccionesGraves { get; set; }

    public string? InfeccionesGraves { get; set; }

    public bool? idInfeccionesGravesTratamiento { get; set; }

    public bool? idEnfermedadRenal { get; set; }

    public string? EnfermedadRenalTiempoEvolcion { get; set; }

    public bool? idEnfermedadRenalTratamiento { get; set; }

    public bool? idOtra { get; set; }

    public string? OtraTiempoEvolucion { get; set; }

    public bool? idOtraTratamiento { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }
}
