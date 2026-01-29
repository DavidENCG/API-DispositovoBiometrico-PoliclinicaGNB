using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Full_Name { get; set; }

    public int? idRol { get; set; }

    public int? idStatus { get; set; }

    public string? Inpsasel { get; set; }

    public string? Msas { get; set; }

    public string? Cedula { get; set; }

    public string? ImageProfile { get; set; }

    public int? idEspecialidad { get; set; }

    public string? ipAddressSession { get; set; }

    public string? hostNameSession { get; set; }

    public string? browserSession { get; set; }

    public string? soSession { get; set; }

    public DateTime? dateSession { get; set; }

    public string? FirmaSelloMedico { get; set; }

    public int? CantidadConsultasDiarias { get; set; }

    public int? ClinicaId { get; set; }

    public int? ProviderId { get; set; }

    public int? dias_expiracion_password_personalizado { get; set; }

    public DateTime? fecha_solicitud_recuperacion { get; set; }

    public string? Email { get; set; }

    public int? intentos_fallidos { get; set; }

    public bool? bloqueado { get; set; }

    public int? tiempo_bloqueo_minutos { get; set; }

    public DateTime? fecha_bloqueo { get; set; }

    public DateTime? fecha_ultimo_cambio_password { get; set; }

    public string? token_recovery { get; set; }

    public bool? EsCuentaPrueba { get; set; }

    public bool? EstaEnUso { get; set; }

    public int? ConteoUsos { get; set; }

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

    public virtual ICollection<AntecedentesHospitalizacion> AntecedentesHospitalizacions { get; set; } = new List<AntecedentesHospitalizacion>();

    public virtual ICollection<AntecedentesPersonalesV2> AntecedentesPersonalesV2s { get; set; } = new List<AntecedentesPersonalesV2>();

    public virtual ICollection<AsignacionesCuentasPrueba> AsignacionesCuentasPruebas { get; set; } = new List<AsignacionesCuentasPrueba>();

    public virtual ICollection<BiometricoMarcaje> BiometricoMarcajes { get; set; } = new List<BiometricoMarcaje>();

    public virtual ICollection<CitasMedica> CitasMedicaidMedicoInterconsultaNavigations { get; set; } = new List<CitasMedica>();

    public virtual ICollection<CitasMedica> CitasMedicaidMedicoNavigations { get; set; } = new List<CitasMedica>();

    public virtual ICollection<CitasMedica> CitasMedicauserCreatedNavigations { get; set; } = new List<CitasMedica>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<ConsultasRemitidasMedicosInterno> ConsultasRemitidasMedicosInternos { get; set; } = new List<ConsultasRemitidasMedicosInterno>();

    public virtual ICollection<CuentasContable> CuentasContableUsuarioCreadors { get; set; } = new List<CuentasContable>();

    public virtual ICollection<CuentasContable> CuentasContableUsuarioModificadors { get; set; } = new List<CuentasContable>();

    public virtual ICollection<Diagnostico> Diagnosticos { get; set; } = new List<Diagnostico>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<EnfermedadActual> EnfermedadActuals { get; set; } = new List<EnfermedadActual>();

    public virtual ICollection<EspecialidadesMedico> EspecialidadesMedicos { get; set; } = new List<EspecialidadesMedico>();

    public virtual ICollection<ExamenFisico2> ExamenFisico2s { get; set; } = new List<ExamenFisico2>();

    public virtual ICollection<ExamenFisico> ExamenFisicos { get; set; } = new List<ExamenFisico>();

    public virtual ICollection<HistoriaOcupacional> HistoriaOcupacionals { get; set; } = new List<HistoriaOcupacional>();

    public virtual ICollection<IndicacionesTerapeutica> IndicacionesTerapeuticas { get; set; } = new List<IndicacionesTerapeutica>();

    public virtual ICollection<InformeMedico> InformeMedicos { get; set; } = new List<InformeMedico>();

    public virtual ICollection<JerarquiaCuentum> JerarquiaCuentumUsuarioCreadors { get; set; } = new List<JerarquiaCuentum>();

    public virtual ICollection<JerarquiaCuentum> JerarquiaCuentumUsuarioModificadors { get; set; } = new List<JerarquiaCuentum>();

    public virtual ICollection<OrdenDeServicio> OrdenDeServicios { get; set; } = new List<OrdenDeServicio>();

    public virtual ICollection<PacienteOncologico> PacienteOncologicos { get; set; } = new List<PacienteOncologico>();

    public virtual ICollection<PlanContableCuenta> PlanContableCuentaUsuarioCreadors { get; set; } = new List<PlanContableCuenta>();

    public virtual ICollection<PlanContableCuenta> PlanContableCuentaUsuarioModificadors { get; set; } = new List<PlanContableCuenta>();

    public virtual ICollection<PlanContable> PlanContableUsuarioCreadors { get; set; } = new List<PlanContable>();

    public virtual ICollection<PlanContable> PlanContableUsuarioModificadors { get; set; } = new List<PlanContable>();

    public virtual Proveedore? Provider { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual ICollection<RegistroPago> RegistroPagos { get; set; } = new List<RegistroPago>();

    public virtual ICollection<ServicioDetalle> ServicioDetalleidMedicoNavigations { get; set; } = new List<ServicioDetalle>();

    public virtual ICollection<ServicioDetalle> ServicioDetalleidProveedorInternoNavigations { get; set; } = new List<ServicioDetalle>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();

    public virtual ICollection<TipoCuentum> TipoCuentumUsuarioCreadors { get; set; } = new List<TipoCuentum>();

    public virtual ICollection<TipoCuentum> TipoCuentumUsuarioModificadors { get; set; } = new List<TipoCuentum>();

    public virtual ICollection<TipoDeSangre> TipoDeSangres { get; set; } = new List<TipoDeSangre>();

    public virtual ICollection<Unidosi> Unidosis { get; set; } = new List<Unidosi>();

    public virtual ICollection<UsuarioClinica> UsuarioClinicas { get; set; } = new List<UsuarioClinica>();

    public virtual Especialidade? idEspecialidadNavigation { get; set; }

    public virtual Rol? idRolNavigation { get; set; }

    public virtual StatusUser? idStatusNavigation { get; set; }
}
