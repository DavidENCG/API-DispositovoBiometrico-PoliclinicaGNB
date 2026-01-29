using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Clinica
{
    public int ID { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Rif { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public bool Activo { get; set; }

    public string UsuarioCreacionId { get; set; } = null!;

    public int ClinicaId { get; set; }

    public string ImageProfile { get; set; } = null!;

    public DateOnly? FechaCreacion { get; set; }

    public string? Tipo { get; set; }

    public bool? EsClinicaPrueba { get; set; }

    public virtual ICollection<AccesoClinicasModulo> AccesoClinicasModulos { get; set; } = new List<AccesoClinicasModulo>();

    public virtual ICollection<AccionesPendientesEnfermerium> AccionesPendientesEnfermeria { get; set; } = new List<AccionesPendientesEnfermerium>();

    public virtual ICollection<Almacene> Almacenes { get; set; } = new List<Almacene>();

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

    public virtual ICollection<AsientosGenerale> AsientosGenerales { get; set; } = new List<AsientosGenerale>();

    public virtual ICollection<AsignacionesCuentasPrueba> AsignacionesCuentasPruebas { get; set; } = new List<AsignacionesCuentasPrueba>();

    public virtual ICollection<Baremo> Baremos { get; set; } = new List<Baremo>();

    public virtual ICollection<BiometricoDispositivo> BiometricoDispositivos { get; set; } = new List<BiometricoDispositivo>();

    public virtual ICollection<BiometricoMarcaje> BiometricoMarcajes { get; set; } = new List<BiometricoMarcaje>();

    public virtual ICollection<BiometricoSyncEstado> BiometricoSyncEstados { get; set; } = new List<BiometricoSyncEstado>();

    public virtual ICollection<Cama> Camas { get; set; } = new List<Cama>();

    public virtual ICollection<CantidadProyeccionesRayosX> CantidadProyeccionesRayosXes { get; set; } = new List<CantidadProyeccionesRayosX>();

    public virtual ICollection<Categorium> Categoria { get; set; } = new List<Categorium>();

    public virtual ICollection<CategoriaItem> CategoriaItems { get; set; } = new List<CategoriaItem>();

    public virtual ICollection<CitasMedica> CitasMedicas { get; set; } = new List<CitasMedica>();

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();

    public virtual ICollection<ClasificacionProveedor> ClasificacionProveedors { get; set; } = new List<ClasificacionProveedor>();

    public virtual ICollection<ClasificacionSangre> ClasificacionSangres { get; set; } = new List<ClasificacionSangre>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<CondicionesProveedor> CondicionesProveedors { get; set; } = new List<CondicionesProveedor>();

    public virtual ICollection<Configuracione> Configuraciones { get; set; } = new List<Configuracione>();

    public virtual ICollection<ConsultasRemitidasMedicosInterno> ConsultasRemitidasMedicosInternos { get; set; } = new List<ConsultasRemitidasMedicosInterno>();

    public virtual ICollection<CostoInforme> CostoInformes { get; set; } = new List<CostoInforme>();

    public virtual ICollection<CostosEstadium> CostosEstadia { get; set; } = new List<CostosEstadium>();

    public virtual ICollection<CuentasContable> CuentasContables { get; set; } = new List<CuentasContable>();

    public virtual ICollection<DLN> DLNs { get; set; } = new List<DLN>();

    public virtual ICollection<DatosExcelString> DatosExcelStrings { get; set; } = new List<DatosExcelString>();

    public virtual ICollection<DetallePresupuesto> DetallePresupuestos { get; set; } = new List<DetallePresupuesto>();

    public virtual ICollection<Diagnostico> Diagnosticos { get; set; } = new List<Diagnostico>();

    public virtual ICollection<DiarioAsientoManualesCabecera> DiarioAsientoManualesCabeceras { get; set; } = new List<DiarioAsientoManualesCabecera>();

    public virtual ICollection<DiarioAsientoManualesLinea> DiarioAsientoManualesLineas { get; set; } = new List<DiarioAsientoManualesLinea>();

    public virtual ICollection<DiarioCobro> DiarioCobros { get; set; } = new List<DiarioCobro>();

    public virtual ICollection<DiarioPago> DiarioPagos { get; set; } = new List<DiarioPago>();

    public virtual ICollection<DiasPago> DiasPagos { get; set; } = new List<DiasPago>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<EnfermedadActual> EnfermedadActuals { get; set; } = new List<EnfermedadActual>();

    public virtual ICollection<Especialidade> Especialidades { get; set; } = new List<Especialidade>();

    public virtual ICollection<EspecialidadesMedico> EspecialidadesMedicos { get; set; } = new List<EspecialidadesMedico>();

    public virtual ICollection<EstadiaPaciente> EstadiaPacientes { get; set; } = new List<EstadiaPaciente>();

    public virtual ICollection<EstadoCivil> EstadoCivils { get; set; } = new List<EstadoCivil>();

    public virtual ICollection<EstadoCuentum> EstadoCuenta { get; set; } = new List<EstadoCuentum>();

    public virtual ICollection<EstadoOrdenSeguro> EstadoOrdenSeguros { get; set; } = new List<EstadoOrdenSeguro>();

    public virtual ICollection<EstadoSintoma> EstadoSintomas { get; set; } = new List<EstadoSintoma>();

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<EstudiosCabecera> EstudiosCabeceras { get; set; } = new List<EstudiosCabecera>();

    public virtual ICollection<EstudiosDetalle> EstudiosDetalles { get; set; } = new List<EstudiosDetalle>();

    public virtual ICollection<EvolucionesEnfermerium> EvolucionesEnfermeria { get; set; } = new List<EvolucionesEnfermerium>();

    public virtual ICollection<ExamenFisico2> ExamenFisico2s { get; set; } = new List<ExamenFisico2>();

    public virtual ICollection<ExamenFisico> ExamenFisicos { get; set; } = new List<ExamenFisico>();

    public virtual ICollection<Examene> Examenes { get; set; } = new List<Examene>();

    public virtual ICollection<ExamenesParaclinico> ExamenesParaclinicos { get; set; } = new List<ExamenesParaclinico>();

    public virtual ICollection<Examenes_ExamenFisico> Examenes_ExamenFisicos { get; set; } = new List<Examenes_ExamenFisico>();

    public virtual ICollection<FactorRH> FactorRHs { get; set; } = new List<FactorRH>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<FormaPago> FormaPagos { get; set; } = new List<FormaPago>();

    public virtual ICollection<FormasPago> FormasPagos { get; set; } = new List<FormasPago>();

    public virtual ICollection<FrecuenciaMenstruacion> FrecuenciaMenstruacions { get; set; } = new List<FrecuenciaMenstruacion>();

    public virtual ICollection<Genero> Generos { get; set; } = new List<Genero>();

    public virtual ICollection<GrupoArticulo> GrupoArticulos { get; set; } = new List<GrupoArticulo>();

    public virtual ICollection<GrupoDeImpuesto> GrupoDeImpuestos { get; set; } = new List<GrupoDeImpuesto>();

    public virtual ICollection<Habitacione> Habitaciones { get; set; } = new List<Habitacione>();

    public virtual ICollection<HistoriaClinica> HistoriaClinicas { get; set; } = new List<HistoriaClinica>();

    public virtual ICollection<HistoriaMotivo> HistoriaMotivos { get; set; } = new List<HistoriaMotivo>();

    public virtual ICollection<HistoriaOcupacional> HistoriaOcupacionals { get; set; } = new List<HistoriaOcupacional>();

    public virtual ICollection<HistorialConversionesUnidade> HistorialConversionesUnidades { get; set; } = new List<HistorialConversionesUnidade>();

    public virtual ICollection<HistorialEvolucion> HistorialEvolucions { get; set; } = new List<HistorialEvolucion>();

    public virtual ICollection<HonorarioBaremo> HonorarioBaremos { get; set; } = new List<HonorarioBaremo>();

    public virtual ICollection<Honorario> Honorarios { get; set; } = new List<Honorario>();

    public virtual ICollection<Impuesto> Impuestos { get; set; } = new List<Impuesto>();

    public virtual ICollection<ImpuestosFactura> ImpuestosFacturas { get; set; } = new List<ImpuestosFactura>();

    public virtual ICollection<IndicacionesTerapeutica> IndicacionesTerapeuticas { get; set; } = new List<IndicacionesTerapeutica>();

    public virtual ICollection<InfoAlcohol> InfoAlcohols { get; set; } = new List<InfoAlcohol>();

    public virtual ICollection<InfoConsumo> InfoConsumos { get; set; } = new List<InfoConsumo>();

    public virtual ICollection<InfoEjercicio> InfoEjercicios { get; set; } = new List<InfoEjercicio>();

    public virtual ICollection<InfoTabaco> InfoTabacos { get; set; } = new List<InfoTabaco>();

    public virtual ICollection<InformeEnfermerium> InformeEnfermeria { get; set; } = new List<InformeEnfermerium>();

    public virtual ICollection<InformeMedico> InformeMedicos { get; set; } = new List<InformeMedico>();

    public virtual ICollection<InventarioFisico> InventarioFisicos { get; set; } = new List<InventarioFisico>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<JerarquiaCuentum> JerarquiaCuenta { get; set; } = new List<JerarquiaCuentum>();

    public virtual ICollection<LineasEstuduio> LineasEstuduios { get; set; } = new List<LineasEstuduio>();

    public virtual ICollection<LineasServicio> LineasServicios { get; set; } = new List<LineasServicio>();

    public virtual ICollection<LogErrorsTrace> LogErrorsTraces { get; set; } = new List<LogErrorsTrace>();

    public virtual ICollection<LotesProducto> LotesProductos { get; set; } = new List<LotesProducto>();

    public virtual ICollection<MaestroCuenta> MaestroCuenta { get; set; } = new List<MaestroCuenta>();

    public virtual ICollection<MetodoCosteo> MetodoCosteos { get; set; } = new List<MetodoCosteo>();

    public virtual ICollection<Modulo> Modulos { get; set; } = new List<Modulo>();

    public virtual ICollection<Monedum> Moneda { get; set; } = new List<Monedum>();

    public virtual ICollection<Monitor> Monitors { get; set; } = new List<Monitor>();

    public virtual ICollection<MotivoConsultum> MotivoConsulta { get; set; } = new List<MotivoConsultum>();

    public virtual ICollection<MotivoReagendum> MotivoReagenda { get; set; } = new List<MotivoReagendum>();

    public virtual ICollection<MovimientoDePaciente> MovimientoDePacientes { get; set; } = new List<MovimientoDePaciente>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<NrComprobanteISRL> NrComprobanteISRLs { get; set; } = new List<NrComprobanteISRL>();

    public virtual ICollection<NrComprobanteIVA> NrComprobanteIVAs { get; set; } = new List<NrComprobanteIVA>();

    public virtual ICollection<NroControlEstudio> NroControlEstudios { get; set; } = new List<NroControlEstudio>();

    public virtual ICollection<NroControlNotaCredito> NroControlNotaCreditos { get; set; } = new List<NroControlNotaCredito>();

    public virtual ICollection<NroControlServicio> NroControlServicios { get; set; } = new List<NroControlServicio>();

    public virtual ICollection<NroFactura> NroFacturas { get; set; } = new List<NroFactura>();

    public virtual ICollection<Odontograma> Odontogramas { get; set; } = new List<Odontograma>();

    public virtual ICollection<Operacione> Operaciones { get; set; } = new List<Operacione>();

    public virtual ICollection<OrdenCompraDetalle> OrdenCompraDetalles { get; set; } = new List<OrdenCompraDetalle>();

    public virtual ICollection<OrdenCompra> OrdenCompras { get; set; } = new List<OrdenCompra>();

    public virtual ICollection<OrdenDeServicio> OrdenDeServicios { get; set; } = new List<OrdenDeServicio>();

    public virtual ICollection<PacienteEnEspera> PacienteEnEsperas { get; set; } = new List<PacienteEnEspera>();

    public virtual ICollection<PacienteOncologico> PacienteOncologicos { get; set; } = new List<PacienteOncologico>();

    public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();

    public virtual ICollection<Paraclinico> Paraclinicos { get; set; } = new List<Paraclinico>();

    public virtual ICollection<Parentesco> Parentescos { get; set; } = new List<Parentesco>();

    public virtual ICollection<Pasillo> Pasillos { get; set; } = new List<Pasillo>();

    public virtual ICollection<PeriodosFiscale> PeriodosFiscales { get; set; } = new List<PeriodosFiscale>();

    public virtual ICollection<Piso> Pisos { get; set; } = new List<Piso>();

    public virtual ICollection<PlanContableCuenta> PlanContableCuenta { get; set; } = new List<PlanContableCuenta>();

    public virtual ICollection<PlanContable> PlanContables { get; set; } = new List<PlanContable>();

    public virtual ICollection<PlantillasMensaje> PlantillasMensajes { get; set; } = new List<PlantillasMensaje>();

    public virtual ICollection<Poliza> Polizas { get; set; } = new List<Poliza>();

    public virtual ICollection<PrefijosCaso> PrefijosCasos { get; set; } = new List<PrefijosCaso>();

    public virtual ICollection<PresupuestoHonorario> PresupuestoHonorarios { get; set; } = new List<PresupuestoHonorario>();

    public virtual ICollection<PresupuestoProducto> PresupuestoProductos { get; set; } = new List<PresupuestoProducto>();

    public virtual ICollection<PresupuestoServicioClinico> PresupuestoServicioClinicos { get; set; } = new List<PresupuestoServicioClinico>();

    public virtual ICollection<Presupuesto> Presupuestos { get; set; } = new List<Presupuesto>();

    public virtual ICollection<ProductoBaremo> ProductoBaremos { get; set; } = new List<ProductoBaremo>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<ProgramacionQuirurgica> ProgramacionQuirurgicas { get; set; } = new List<ProgramacionQuirurgica>();

    public virtual ICollection<PropuestaPago> PropuestaPagos { get; set; } = new List<PropuestaPago>();

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual ICollection<RegistroPago> RegistroPagos { get; set; } = new List<RegistroPago>();

    public virtual ICollection<ReglasConversionUnidade> ReglasConversionUnidades { get; set; } = new List<ReglasConversionUnidade>();

    public virtual ICollection<Religion> Religions { get; set; } = new List<Religion>();

    public virtual ICollection<ResRapidum> ResRapida { get; set; } = new List<ResRapidum>();

    public virtual ICollection<ReservaEmergencium> ReservaEmergencia { get; set; } = new List<ReservaEmergencium>();

    public virtual ICollection<ReservaHospitalizacion> ReservaHospitalizacions { get; set; } = new List<ReservaHospitalizacion>();

    public virtual ICollection<RetencionesFactura> RetencionesFacturas { get; set; } = new List<RetencionesFactura>();

    public virtual ICollection<Rol_Operacione> Rol_Operaciones { get; set; } = new List<Rol_Operacione>();

    public virtual ICollection<Rol> Rols { get; set; } = new List<Rol>();

    public virtual ICollection<SeguroCasosEmergencium> SeguroCasosEmergencia { get; set; } = new List<SeguroCasosEmergencium>();

    public virtual ICollection<Seguro> Seguros { get; set; } = new List<Seguro>();

    public virtual ICollection<SegurosAdmitido> SegurosAdmitidos { get; set; } = new List<SegurosAdmitido>();

    public virtual ICollection<SegurosPaciente> SegurosPacientes { get; set; } = new List<SegurosPaciente>();

    public virtual ICollection<ServicioClinicoBaremo> ServicioClinicoBaremos { get; set; } = new List<ServicioClinicoBaremo>();

    public virtual ICollection<ServicioClinico> ServicioClinicos { get; set; } = new List<ServicioClinico>();

    public virtual ICollection<ServicioDeEspacio> ServicioDeEspacios { get; set; } = new List<ServicioDeEspacio>();

    public virtual ICollection<ServicioDetalle> ServicioDetalles { get; set; } = new List<ServicioDetalle>();

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();

    public virtual ICollection<ServiciosConfigurable> ServiciosConfigurables { get; set; } = new List<ServiciosConfigurable>();

    public virtual ICollection<ServiciosProveedore> ServiciosProveedores { get; set; } = new List<ServiciosProveedore>();

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();

    public virtual ICollection<StatusCaso> StatusCasos { get; set; } = new List<StatusCaso>();

    public virtual ICollection<StatusCitum> StatusCita { get; set; } = new List<StatusCitum>();

    public virtual ICollection<StatusConfirmacion> StatusConfirmacions { get; set; } = new List<StatusConfirmacion>();

    public virtual ICollection<StatusFacturacion> StatusFacturacions { get; set; } = new List<StatusFacturacion>();

    public virtual ICollection<StatusMovimientoInventario> StatusMovimientoInventarios { get; set; } = new List<StatusMovimientoInventario>();

    public virtual ICollection<StatusOrden> StatusOrdens { get; set; } = new List<StatusOrden>();

    public virtual ICollection<StatusPago> StatusPagos { get; set; } = new List<StatusPago>();

    public virtual ICollection<StatusPresupuesto> StatusPresupuestos { get; set; } = new List<StatusPresupuesto>();

    public virtual ICollection<StatusUser> StatusUsers { get; set; } = new List<StatusUser>();

    public virtual ICollection<SubCategorium> SubCategoria { get; set; } = new List<SubCategorium>();

    public virtual ICollection<TasaCambio> TasaCambios { get; set; } = new List<TasaCambio>();

    public virtual ICollection<TipoAlmacen> TipoAlmacens { get; set; } = new List<TipoAlmacen>();

    public virtual ICollection<TipoCliente> TipoClientes { get; set; } = new List<TipoCliente>();

    public virtual ICollection<TipoCuentum> TipoCuenta { get; set; } = new List<TipoCuentum>();

    public virtual ICollection<TipoDeSangre> TipoDeSangres { get; set; } = new List<TipoDeSangre>();

    public virtual ICollection<TipoEnfermedade> TipoEnfermedades { get; set; } = new List<TipoEnfermedade>();

    public virtual ICollection<TipoEstudio> TipoEstudios { get; set; } = new List<TipoEstudio>();

    public virtual ICollection<TipoExaman> TipoExamen { get; set; } = new List<TipoExaman>();

    public virtual ICollection<TipoIVA> TipoIVAs { get; set; } = new List<TipoIVA>();

    public virtual ICollection<TipoInformeMedico> TipoInformeMedicos { get; set; } = new List<TipoInformeMedico>();

    public virtual ICollection<TipoInterconsultum> TipoInterconsulta { get; set; } = new List<TipoInterconsultum>();

    public virtual ICollection<TipoMovimiento> TipoMovimientos { get; set; } = new List<TipoMovimiento>();

    public virtual ICollection<TipoPago> TipoPagos { get; set; } = new List<TipoPago>();

    public virtual ICollection<TipoPersona> TipoPersonas { get; set; } = new List<TipoPersona>();

    public virtual ICollection<TipoProyeccionesRayosX> TipoProyeccionesRayosXes { get; set; } = new List<TipoProyeccionesRayosX>();

    public virtual ICollection<TipoRayosX> TipoRayosXes { get; set; } = new List<TipoRayosX>();

    public virtual ICollection<TipoUnidadMedidum> TipoUnidadMedida { get; set; } = new List<TipoUnidadMedidum>();

    public virtual ICollection<TiposExamenesInforme> TiposExamenesInformes { get; set; } = new List<TiposExamenesInforme>();

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    public virtual ICollection<Ubicacione> Ubicaciones { get; set; } = new List<Ubicacione>();

    public virtual ICollection<Unidosi> Unidosis { get; set; } = new List<Unidosi>();

    public virtual ICollection<UsuarioClinica> UsuarioClinicas { get; set; } = new List<UsuarioClinica>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<ViaAdministracion> ViaAdministracions { get; set; } = new List<ViaAdministracion>();

    public virtual ICollection<ZonaExamenFisico> ZonaExamenFisicos { get; set; } = new List<ZonaExamenFisico>();

    public virtual ICollection<pruebaitem> pruebaitems { get; set; } = new List<pruebaitem>();
}
