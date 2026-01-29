using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesPersonales_HC
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public bool? Diabetes { get; set; }

    public string? DiabetesTiempoEvolucion { get; set; }

    public bool? DiabetesTratamiento { get; set; }

    public bool? Hipertension { get; set; }

    public string? HipertensionTiempoEvolucion { get; set; }

    public bool? HipertensionTratamiento { get; set; }

    public bool? Cardiaca { get; set; }

    public string? CardiacaTiempoEvolucion { get; set; }

    public bool? CardiacaTratamiento { get; set; }

    public bool? Respiratoria { get; set; }

    public string? RespiratorioTiempoEvolucion { get; set; }

    public bool? RespiratorioTratamiento { get; set; }

    public bool? Cancer { get; set; }

    public string? CancerTiempoEvolucion { get; set; }

    public bool? CancerTratamiento { get; set; }

    public bool? DefectosGeneticos { get; set; }

    public string? DefectosGeneticosTiempoEvolucion { get; set; }

    public bool? DefectosGeneticosTratamiento { get; set; }

    public bool? EnfermedadMental { get; set; }

    public string? EnfermedadMentalTiempoEvolucion { get; set; }

    public bool? EnfermedadMentalTratamiento { get; set; }

    public bool? Osteoporosis { get; set; }

    public string? OsteoporosisTiempoEvolucion { get; set; }

    public bool? OsteoporosisTratamiento { get; set; }

    public bool? Reumatica { get; set; }

    public string? ReumaticaTiempoEvolucion { get; set; }

    public bool? ReumaticaTratamiento { get; set; }

    public bool? Convulsiones { get; set; }

    public string? ConvulsionesTiempoEvolucion { get; set; }

    public bool? ConvulsionesTratamiento { get; set; }

    public bool? TrastornoHemorragico { get; set; }

    public string? TrastornoHemorragicoTiempoEvolucion { get; set; }

    public bool? TrastornoHemorragicoTratamiento { get; set; }

    public bool? InfeccionesGraves { get; set; }

    public string? InfeccionesGravesTiempoEvolucion { get; set; }

    public bool? InfeccionesGravesTratamiento { get; set; }

    public bool? EnfermedadRenal { get; set; }

    public string? EnfermedadRenalTiempoEvolucion { get; set; }

    public bool? EnfermedadRenalTratamiento { get; set; }

    public bool? Otra { get; set; }

    public string? OtraTiempoEvolucion { get; set; }

    public bool? OtraTratamiento { get; set; }

    public int? ClinicaId { get; set; }

    public bool? DiabetesPresento { get; set; }

    public bool? HipertensionPresento { get; set; }

    public bool? CardiacaPresento { get; set; }

    public bool? RespiratoriaPresento { get; set; }

    public bool? CancerPresento { get; set; }

    public bool? DefectosGeneticosPresento { get; set; }

    public bool? EnfermedadMentalPresento { get; set; }

    public bool? OsteoporosisPresento { get; set; }

    public bool? ReumaticaPresento { get; set; }

    public bool? ConvulsionesPresento { get; set; }

    public bool? TrastornoHemorragicoPresento { get; set; }

    public bool? InfeccionesGravesPresento { get; set; }

    public bool? EnfermedadRenalPresento { get; set; }

    public bool? OtraPresento { get; set; }

    public string? PostCovidDescripcion { get; set; }

    public bool? PostCovid { get; set; }

    public string? VacunasDescripcion { get; set; }

    public bool? Vacunas { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }
}
