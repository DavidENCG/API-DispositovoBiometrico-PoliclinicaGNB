using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public string? Cedula { get; set; }

    public string? PrimerNombre { get; set; }

    public string? SegundoNombre { get; set; }

    public string? PrimerApellido { get; set; }

    public string? SegundoApellido { get; set; }

    public string? LugarNacimiento { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public int? Edad { get; set; }

    public int? NroHijos { get; set; }

    public int? idGenero { get; set; }

    public int? idEstadoCivil { get; set; }

    public string? Ocupacion { get; set; }

    public string? Empresa { get; set; }

    public string? DireccionHabitacion { get; set; }

    public string? DireccionTrabajo { get; set; }

    public string? TelefonoHabitacion { get; set; }

    public string? TelefonoTrabajo { get; set; }

    public string? TelefonoCelular { get; set; }

    public string? TelefonoFamiliar { get; set; }

    public string? TelefonoAcompañante { get; set; }

    public string? Responsable { get; set; }

    public string? Parentesco { get; set; }

    public string? TelefonoResponsable { get; set; }

    public string? DelegadoConsularResp { get; set; }

    public int? idMenorDeEdad { get; set; }

    public string? Correo { get; set; }

    public int? idReligion { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ClinicaId { get; set; }

    public string? PrefijoCaso { get; set; }

    public string? GrupoSanguineo { get; set; }

    public string? NroHistoria { get; set; }

    public virtual ICollection<AntMedicamentosActuale> AntMedicamentosActuales { get; set; } = new List<AntMedicamentosActuale>();

    public virtual ICollection<AntecedentesAlergico> AntecedentesAlergicos { get; set; } = new List<AntecedentesAlergico>();

    public virtual ICollection<AntecedentesAlergicos_HC> AntecedentesAlergicos_HCs { get; set; } = new List<AntecedentesAlergicos_HC>();

    public virtual ICollection<AntecedentesEnfermedadesInfectocontagiosasInfanca> AntecedentesEnfermedadesInfectocontagiosasInfancas { get; set; } = new List<AntecedentesEnfermedadesInfectocontagiosasInfanca>();

    public virtual ICollection<AntecedentesEnfermedadesInfectocontagiosasInfancia_HC> AntecedentesEnfermedadesInfectocontagiosasInfancia_HCs { get; set; } = new List<AntecedentesEnfermedadesInfectocontagiosasInfancia_HC>();

    public virtual ICollection<AntecedentesFamiliare> AntecedentesFamiliares { get; set; } = new List<AntecedentesFamiliare>();

    public virtual ICollection<AntecedentesFamiliares_HC> AntecedentesFamiliares_HCs { get; set; } = new List<AntecedentesFamiliares_HC>();

    public virtual ICollection<AntecedentesGinecobstetrico> AntecedentesGinecobstetricos { get; set; } = new List<AntecedentesGinecobstetrico>();

    public virtual ICollection<AntecedentesGinecobstetricos_HC> AntecedentesGinecobstetricos_HCs { get; set; } = new List<AntecedentesGinecobstetricos_HC>();

    public virtual ICollection<AntecedentesHabitosPsicobiologico> AntecedentesHabitosPsicobiologicos { get; set; } = new List<AntecedentesHabitosPsicobiologico>();

    public virtual ICollection<AntecedentesHabitosPsicobiologicos_HC> AntecedentesHabitosPsicobiologicos_HCs { get; set; } = new List<AntecedentesHabitosPsicobiologicos_HC>();

    public virtual ICollection<AntecedentesHematologico> AntecedentesHematologicos { get; set; } = new List<AntecedentesHematologico>();

    public virtual ICollection<AntecedentesHematologicos_HC> AntecedentesHematologicos_HCs { get; set; } = new List<AntecedentesHematologicos_HC>();

    public virtual ICollection<AntecedentesHospitalizacion_HC> AntecedentesHospitalizacion_HCs { get; set; } = new List<AntecedentesHospitalizacion_HC>();

    public virtual ICollection<AntecedentesHospitalizacion> AntecedentesHospitalizacions { get; set; } = new List<AntecedentesHospitalizacion>();

    public virtual ICollection<AntecedentesMedicamentosActuales_HC> AntecedentesMedicamentosActuales_HCs { get; set; } = new List<AntecedentesMedicamentosActuales_HC>();

    public virtual ICollection<AntecedentesPersonale> AntecedentesPersonales { get; set; } = new List<AntecedentesPersonale>();

    public virtual ICollection<AntecedentesPersonalesV2> AntecedentesPersonalesV2s { get; set; } = new List<AntecedentesPersonalesV2>();

    public virtual ICollection<AntecedentesPersonales_HC> AntecedentesPersonales_HCs { get; set; } = new List<AntecedentesPersonales_HC>();

    public virtual ICollection<AntecedentesQuirurgico> AntecedentesQuirurgicos { get; set; } = new List<AntecedentesQuirurgico>();

    public virtual ICollection<AntecedentesQuirurgicos_HC> AntecedentesQuirurgicos_HCs { get; set; } = new List<AntecedentesQuirurgicos_HC>();

    public virtual ICollection<CitasMedica> CitasMedicas { get; set; } = new List<CitasMedica>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<ConsultasRemitidasMedicosInterno> ConsultasRemitidasMedicosInternos { get; set; } = new List<ConsultasRemitidasMedicosInterno>();

    public virtual ICollection<Diagnostico> Diagnosticos { get; set; } = new List<Diagnostico>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<EnfermedadActual> EnfermedadActuals { get; set; } = new List<EnfermedadActual>();

    public virtual ICollection<EstadiaPaciente> EstadiaPacientes { get; set; } = new List<EstadiaPaciente>();

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<EstudiosCabecera> EstudiosCabeceras { get; set; } = new List<EstudiosCabecera>();

    public virtual ICollection<ExamenFisico2> ExamenFisico2s { get; set; } = new List<ExamenFisico2>();

    public virtual ICollection<ExamenFisico> ExamenFisicos { get; set; } = new List<ExamenFisico>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<HistoriaClinica> HistoriaClinicas { get; set; } = new List<HistoriaClinica>();

    public virtual ICollection<HistoriaOcupacional> HistoriaOcupacionals { get; set; } = new List<HistoriaOcupacional>();

    public virtual ICollection<IndicacionesTerapeutica> IndicacionesTerapeuticas { get; set; } = new List<IndicacionesTerapeutica>();

    public virtual ICollection<InformeEnfermerium> InformeEnfermeria { get; set; } = new List<InformeEnfermerium>();

    public virtual ICollection<InformeMedico> InformeMedicos { get; set; } = new List<InformeMedico>();

    public virtual ICollection<MovimientoDePaciente> MovimientoDePacientes { get; set; } = new List<MovimientoDePaciente>();

    public virtual ICollection<OrdenDeServicio> OrdenDeServicios { get; set; } = new List<OrdenDeServicio>();

    public virtual ICollection<PacienteEnEspera> PacienteEnEsperas { get; set; } = new List<PacienteEnEspera>();

    public virtual ICollection<PacienteOncologico> PacienteOncologicos { get; set; } = new List<PacienteOncologico>();

    public virtual ICollection<Paraclinico> Paraclinicos { get; set; } = new List<Paraclinico>();

    public virtual ICollection<ProgramacionQuirurgica> ProgramacionQuirurgicas { get; set; } = new List<ProgramacionQuirurgica>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual ICollection<ReservaEmergencium> ReservaEmergencia { get; set; } = new List<ReservaEmergencium>();

    public virtual ICollection<SeguroCasosEmergencium> SeguroCasosEmergencia { get; set; } = new List<SeguroCasosEmergencium>();

    public virtual ICollection<SegurosPaciente> SegurosPacientes { get; set; } = new List<SegurosPaciente>();

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();

    public virtual ICollection<TipoDeSangre> TipoDeSangres { get; set; } = new List<TipoDeSangre>();

    public virtual ICollection<Unidosi> Unidosis { get; set; } = new List<Unidosi>();

    public virtual EstadoCivil? idEstadoCivilNavigation { get; set; }

    public virtual Genero? idGeneroNavigation { get; set; }

    public virtual ResRapidum? idMenorDeEdadNavigation { get; set; }

    public virtual Religion? idReligionNavigation { get; set; }
}
