using System;
using System.Collections.Generic;
using ApiControlAsistenciaBiometrico.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiControlAsistenciaBiometrico.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccesoClinicasModulo> AccesoClinicasModulos { get; set; }

    public virtual DbSet<AccionesPendientesEnfermerium> AccionesPendientesEnfermeria { get; set; }

    public virtual DbSet<Almacene> Almacenes { get; set; }

    public virtual DbSet<AntMedicamentosActuale> AntMedicamentosActuales { get; set; }

    public virtual DbSet<AntecedentesAlergico> AntecedentesAlergicos { get; set; }

    public virtual DbSet<AntecedentesAlergicos_HC> AntecedentesAlergicos_HCs { get; set; }

    public virtual DbSet<AntecedentesEnfermedadesInfectocontagiosasInfanca> AntecedentesEnfermedadesInfectocontagiosasInfancas { get; set; }

    public virtual DbSet<AntecedentesEnfermedadesInfectocontagiosasInfancia_HC> AntecedentesEnfermedadesInfectocontagiosasInfancia_HCs { get; set; }

    public virtual DbSet<AntecedentesFamiliare> AntecedentesFamiliares { get; set; }

    public virtual DbSet<AntecedentesFamiliares_HC> AntecedentesFamiliares_HCs { get; set; }

    public virtual DbSet<AntecedentesGinecobstetrico> AntecedentesGinecobstetricos { get; set; }

    public virtual DbSet<AntecedentesGinecobstetricos_HC> AntecedentesGinecobstetricos_HCs { get; set; }

    public virtual DbSet<AntecedentesHabitosPsicobiologico> AntecedentesHabitosPsicobiologicos { get; set; }

    public virtual DbSet<AntecedentesHabitosPsicobiologicos_HC> AntecedentesHabitosPsicobiologicos_HCs { get; set; }

    public virtual DbSet<AntecedentesHematologico> AntecedentesHematologicos { get; set; }

    public virtual DbSet<AntecedentesHematologicos_HC> AntecedentesHematologicos_HCs { get; set; }

    public virtual DbSet<AntecedentesHospitalizacion> AntecedentesHospitalizacions { get; set; }

    public virtual DbSet<AntecedentesHospitalizacion_HC> AntecedentesHospitalizacion_HCs { get; set; }

    public virtual DbSet<AntecedentesMedicamentosActuales_HC> AntecedentesMedicamentosActuales_HCs { get; set; }

    public virtual DbSet<AntecedentesPersonale> AntecedentesPersonales { get; set; }

    public virtual DbSet<AntecedentesPersonalesV2> AntecedentesPersonalesV2s { get; set; }

    public virtual DbSet<AntecedentesPersonales_HC> AntecedentesPersonales_HCs { get; set; }

    public virtual DbSet<AntecedentesQuirurgico> AntecedentesQuirurgicos { get; set; }

    public virtual DbSet<AntecedentesQuirurgicos_HC> AntecedentesQuirurgicos_HCs { get; set; }

    public virtual DbSet<AsientosGenerale> AsientosGenerales { get; set; }

    public virtual DbSet<AsignacionesCuentasPrueba> AsignacionesCuentasPruebas { get; set; }

    public virtual DbSet<BancoMonedum> BancoMoneda { get; set; }

    public virtual DbSet<Baremo> Baremos { get; set; }

    public virtual DbSet<BiometricoDispositivo> BiometricoDispositivos { get; set; }

    public virtual DbSet<BiometricoMarcaje> BiometricoMarcajes { get; set; }

    public virtual DbSet<BiometricoSyncEstado> BiometricoSyncEstados { get; set; }

    public virtual DbSet<Cama> Camas { get; set; }

    public virtual DbSet<CantidadProyeccionesRayosX> CantidadProyeccionesRayosXes { get; set; }

    public virtual DbSet<CategoriaItem> CategoriaItems { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<CitasMedica> CitasMedicas { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<ClasificacionProveedor> ClasificacionProveedors { get; set; }

    public virtual DbSet<ClasificacionSangre> ClasificacionSangres { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Clinica> Clinicas { get; set; }

    public virtual DbSet<CondicionesProveedor> CondicionesProveedors { get; set; }

    public virtual DbSet<ConfiguracionMonedum> ConfiguracionMoneda { get; set; }

    public virtual DbSet<Configuracione> Configuraciones { get; set; }

    public virtual DbSet<ConsultasRemitidasMedicosInterno> ConsultasRemitidasMedicosInternos { get; set; }

    public virtual DbSet<CostoInforme> CostoInformes { get; set; }

    public virtual DbSet<CostosEstadium> CostosEstadia { get; set; }

    public virtual DbSet<CuentaSegmento> CuentaSegmentos { get; set; }

    public virtual DbSet<CuentasContable> CuentasContables { get; set; }

    public virtual DbSet<DLN> DLNs { get; set; }

    public virtual DbSet<DatosExcelString> DatosExcelStrings { get; set; }

    public virtual DbSet<DefinicionGrupoImpuesto> DefinicionGrupoImpuestos { get; set; }

    public virtual DbSet<DetallePresupuesto> DetallePresupuestos { get; set; }

    public virtual DbSet<Diagnostico> Diagnosticos { get; set; }

    public virtual DbSet<DiarioAsientoManualesCabecera> DiarioAsientoManualesCabeceras { get; set; }

    public virtual DbSet<DiarioAsientoManualesLinea> DiarioAsientoManualesLineas { get; set; }

    public virtual DbSet<DiarioCobro> DiarioCobros { get; set; }

    public virtual DbSet<DiarioPago> DiarioPagos { get; set; }

    public virtual DbSet<DiasPago> DiasPagos { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<EnfermedadActual> EnfermedadActuals { get; set; }

    public virtual DbSet<Especialidade> Especialidades { get; set; }

    public virtual DbSet<EspecialidadesMedico> EspecialidadesMedicos { get; set; }

    public virtual DbSet<EstadiaPaciente> EstadiaPacientes { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<EstadoCirugium> EstadoCirugia { get; set; }

    public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }

    public virtual DbSet<EstadoCuentum> EstadoCuenta { get; set; }

    public virtual DbSet<EstadoOrdenSeguro> EstadoOrdenSeguros { get; set; }

    public virtual DbSet<EstadoSintoma> EstadoSintomas { get; set; }

    public virtual DbSet<EstructurasContable> EstructurasContables { get; set; }

    public virtual DbSet<Estudio> Estudios { get; set; }

    public virtual DbSet<EstudiosCabecera> EstudiosCabeceras { get; set; }

    public virtual DbSet<EstudiosDetalle> EstudiosDetalles { get; set; }

    public virtual DbSet<EvolucionesEnfermerium> EvolucionesEnfermeria { get; set; }

    public virtual DbSet<ExamenFisico> ExamenFisicos { get; set; }

    public virtual DbSet<ExamenFisico2> ExamenFisico2s { get; set; }

    public virtual DbSet<Examene> Examenes { get; set; }

    public virtual DbSet<ExamenesParaclinico> ExamenesParaclinicos { get; set; }

    public virtual DbSet<Examenes_ExamenFisico> Examenes_ExamenFisicos { get; set; }

    public virtual DbSet<FactorRH> FactorRHs { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<FormasPago> FormasPagos { get; set; }

    public virtual DbSet<FrecuenciaMenstruacion> FrecuenciaMenstruacions { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<GrupoArticulo> GrupoArticulos { get; set; }

    public virtual DbSet<GrupoDeImpuesto> GrupoDeImpuestos { get; set; }

    public virtual DbSet<GruposCliente> GruposClientes { get; set; }

    public virtual DbSet<GruposProveedore> GruposProveedores { get; set; }

    public virtual DbSet<Habitacione> Habitaciones { get; set; }

    public virtual DbSet<HistoriaClinica> HistoriaClinicas { get; set; }

    public virtual DbSet<HistoriaMotivo> HistoriaMotivos { get; set; }

    public virtual DbSet<HistoriaOcupacional> HistoriaOcupacionals { get; set; }

    public virtual DbSet<HistorialConversionesUnidade> HistorialConversionesUnidades { get; set; }

    public virtual DbSet<HistorialEvolucion> HistorialEvolucions { get; set; }

    public virtual DbSet<HistorialImpuesto> HistorialImpuestos { get; set; }

    public virtual DbSet<Honorario> Honorarios { get; set; }

    public virtual DbSet<HonorarioBaremo> HonorarioBaremos { get; set; }

    public virtual DbSet<Imagene> Imagenes { get; set; }

    public virtual DbSet<Impuesto> Impuestos { get; set; }

    public virtual DbSet<ImpuestoServicio> ImpuestoServicios { get; set; }

    public virtual DbSet<ImpuestosFactura> ImpuestosFacturas { get; set; }

    public virtual DbSet<ImpuestosItem> ImpuestosItems { get; set; }

    public virtual DbSet<ImpuestosRetencione> ImpuestosRetenciones { get; set; }

    public virtual DbSet<IndicacionesTerapeutica> IndicacionesTerapeuticas { get; set; }

    public virtual DbSet<InfoAlcohol> InfoAlcohols { get; set; }

    public virtual DbSet<InfoConsumo> InfoConsumos { get; set; }

    public virtual DbSet<InfoEjercicio> InfoEjercicios { get; set; }

    public virtual DbSet<InfoTabaco> InfoTabacos { get; set; }

    public virtual DbSet<InformeEnfermerium> InformeEnfermeria { get; set; }

    public virtual DbSet<InformeMedico> InformeMedicos { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<InventarioFisico> InventarioFisicos { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<JerarquiaCuentum> JerarquiaCuenta { get; set; }

    public virtual DbSet<LineasEstuduio> LineasEstuduios { get; set; }

    public virtual DbSet<LineasServicio> LineasServicios { get; set; }

    public virtual DbSet<LogErrorsTrace> LogErrorsTraces { get; set; }

    public virtual DbSet<LotesProducto> LotesProductos { get; set; }

    public virtual DbSet<MaestroCuenta> MaestroCuentas { get; set; }

    public virtual DbSet<MedicamentoFormula> MedicamentoFormulas { get; set; }

    public virtual DbSet<MetodoCosteo> MetodoCosteos { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<Modulo> Modulos { get; set; }

    public virtual DbSet<ModulosClinica> ModulosClinicas { get; set; }

    public virtual DbSet<Monedum> Moneda { get; set; }

    //public virtual DbSet<Monitor> Monitors { get; set; }

    public virtual DbSet<MotivoConsultum> MotivoConsulta { get; set; }

    public virtual DbSet<MotivoReagendum> MotivoReagenda { get; set; }

    public virtual DbSet<MovimientoDePaciente> MovimientoDePacientes { get; set; }

    public virtual DbSet<MovimientoInventario> MovimientoInventarios { get; set; }

    public virtual DbSet<NrComprobanteISRL> NrComprobanteISRLs { get; set; }

    public virtual DbSet<NrComprobanteIVA> NrComprobanteIVAs { get; set; }

    public virtual DbSet<NroCaso> NroCasos { get; set; }

    public virtual DbSet<NroControl> NroControls { get; set; }

    public virtual DbSet<NroControlEstudio> NroControlEstudios { get; set; }

    public virtual DbSet<NroControlNotaCredito> NroControlNotaCreditos { get; set; }

    public virtual DbSet<NroControlServicio> NroControlServicios { get; set; }

    public virtual DbSet<NroFactura> NroFacturas { get; set; }

    public virtual DbSet<NroNotaC> NroNotaCs { get; set; }

    public virtual DbSet<NroNotaD> NroNotaDs { get; set; }

    public virtual DbSet<Odontograma> Odontogramas { get; set; }

    public virtual DbSet<Operacione> Operaciones { get; set; }

    public virtual DbSet<OrdenCompra> OrdenCompras { get; set; }

    public virtual DbSet<OrdenCompraDetalle> OrdenCompraDetalles { get; set; }

    public virtual DbSet<OrdenDeServicio> OrdenDeServicios { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<PacienteEnEspera> PacienteEnEsperas { get; set; }

    public virtual DbSet<PacienteOncologico> PacienteOncologicos { get; set; }

    public virtual DbSet<PagoClasificacion> PagoClasificacions { get; set; }

    public virtual DbSet<Paraclinico> Paraclinicos { get; set; }

    public virtual DbSet<Parentesco> Parentescos { get; set; }

    public virtual DbSet<Pasillo> Pasillos { get; set; }

    public virtual DbSet<PerfilesCliente> PerfilesClientes { get; set; }

    public virtual DbSet<PerfilesProveedore> PerfilesProveedores { get; set; }

    public virtual DbSet<PeriodosFiscale> PeriodosFiscales { get; set; }

    public virtual DbSet<Piso> Pisos { get; set; }

    public virtual DbSet<PlanContable> PlanContables { get; set; }

    public virtual DbSet<PlanContableCuenta> PlanContableCuentas { get; set; }

    public virtual DbSet<PlantillasMensaje> PlantillasMensajes { get; set; }

    public virtual DbSet<Poliza> Polizas { get; set; }

    public virtual DbSet<PrefijosCaso> PrefijosCasos { get; set; }

    public virtual DbSet<Presupuesto> Presupuestos { get; set; }

    public virtual DbSet<PresupuestoHonorario> PresupuestoHonorarios { get; set; }

    public virtual DbSet<PresupuestoProducto> PresupuestoProductos { get; set; }

    public virtual DbSet<PresupuestoServicioClinico> PresupuestoServicioClinicos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoBaremo> ProductoBaremos { get; set; }

    public virtual DbSet<ProgramacionQuirurgica> ProgramacionQuirurgicas { get; set; }

    public virtual DbSet<PropuestaPago> PropuestaPagos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<RegistroFactua> RegistroFactuas { get; set; }

    public virtual DbSet<RegistroPago> RegistroPagos { get; set; }

    public virtual DbSet<ReglasConversionUnidade> ReglasConversionUnidades { get; set; }

    public virtual DbSet<Religion> Religions { get; set; }

    public virtual DbSet<ResRapidum> ResRapida { get; set; }

    public virtual DbSet<ReservaEmergencium> ReservaEmergencia { get; set; }

    public virtual DbSet<ReservaHospitalizacion> ReservaHospitalizacions { get; set; }

    public virtual DbSet<RetencionServicio> RetencionServicios { get; set; }

    public virtual DbSet<Retencione> Retenciones { get; set; }

    public virtual DbSet<RetencionesFactura> RetencionesFacturas { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Rol_Operacione> Rol_Operaciones { get; set; }

    public virtual DbSet<SegmentosContable> SegmentosContables { get; set; }

    public virtual DbSet<Seguro> Seguros { get; set; }

    public virtual DbSet<SeguroCasosEmergencium> SeguroCasosEmergencia { get; set; }

    public virtual DbSet<SegurosAdmitido> SegurosAdmitidos { get; set; }

    public virtual DbSet<SegurosPaciente> SegurosPacientes { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<ServicioClinico> ServicioClinicos { get; set; }

    public virtual DbSet<ServicioClinicoBaremo> ServicioClinicoBaremos { get; set; }

    public virtual DbSet<ServicioDeEspacio> ServicioDeEspacios { get; set; }

    public virtual DbSet<ServicioDetalle> ServicioDetalles { get; set; }

    public virtual DbSet<ServiciosConfigurable> ServiciosConfigurables { get; set; }

    public virtual DbSet<ServiciosProveedore> ServiciosProveedores { get; set; }

    public virtual DbSet<Solicitud> Solicituds { get; set; }

    public virtual DbSet<StatusCaso> StatusCasos { get; set; }

    public virtual DbSet<StatusCitum> StatusCita { get; set; }

    public virtual DbSet<StatusConfirmacion> StatusConfirmacions { get; set; }

    public virtual DbSet<StatusFacturacion> StatusFacturacions { get; set; }

    public virtual DbSet<StatusMovimientoInventario> StatusMovimientoInventarios { get; set; }

    public virtual DbSet<StatusOrden> StatusOrdens { get; set; }

    public virtual DbSet<StatusOrdenCompra> StatusOrdenCompras { get; set; }

    public virtual DbSet<StatusPago> StatusPagos { get; set; }

    public virtual DbSet<StatusPresupuesto> StatusPresupuestos { get; set; }

    public virtual DbSet<StatusUser> StatusUsers { get; set; }

    public virtual DbSet<SubCategorium> SubCategoria { get; set; }

    public virtual DbSet<TasaCambio> TasaCambios { get; set; }

    public virtual DbSet<TipoAlmacen> TipoAlmacens { get; set; }

    public virtual DbSet<TipoBanco> TipoBancos { get; set; }

    public virtual DbSet<TipoCliente> TipoClientes { get; set; }

    public virtual DbSet<TipoCuentum> TipoCuenta { get; set; }

    public virtual DbSet<TipoDeSangre> TipoDeSangres { get; set; }

    public virtual DbSet<TipoDocumentacion> TipoDocumentacions { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoEnfermedade> TipoEnfermedades { get; set; }

    public virtual DbSet<TipoEstudio> TipoEstudios { get; set; }

    public virtual DbSet<TipoExaman> TipoExamen { get; set; }

    public virtual DbSet<TipoFactura> TipoFacturas { get; set; }

    public virtual DbSet<TipoIVA> TipoIVAs { get; set; }

    public virtual DbSet<TipoInformeMedico> TipoInformeMedicos { get; set; }

    public virtual DbSet<TipoInterconsultum> TipoInterconsulta { get; set; }

    public virtual DbSet<TipoMovimiento> TipoMovimientos { get; set; }

    public virtual DbSet<TipoPago> TipoPagos { get; set; }

    public virtual DbSet<TipoPersona> TipoPersonas { get; set; }

    public virtual DbSet<TipoProyeccionesRayosX> TipoProyeccionesRayosXes { get; set; }

    public virtual DbSet<TipoRayosX> TipoRayosXes { get; set; }

    public virtual DbSet<TipoRetencion> TipoRetencions { get; set; }

    public virtual DbSet<TipoUnidadMedidum> TipoUnidadMedida { get; set; }

    public virtual DbSet<TiposExamenesInforme> TiposExamenesInformes { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    public virtual DbSet<Ubicacione> Ubicaciones { get; set; }

    public virtual DbSet<UnidadesMedida> UnidadesMedidas { get; set; }

    public virtual DbSet<Unidosi> Unidoses { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioClinica> UsuarioClinicas { get; set; }

    public virtual DbSet<Valore> Valores { get; set; }

    public virtual DbSet<ValoresImpuesto> ValoresImpuestos { get; set; }

    public virtual DbSet<ValoresSegmento> ValoresSegmentos { get; set; }

    public virtual DbSet<ViaAdministracion> ViaAdministracions { get; set; }

    public virtual DbSet<ZonaExamenFisico> ZonaExamenFisicos { get; set; }

    public virtual DbSet<pruebaitem> pruebaitems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccesoClinicasModulo>(entity =>
        {
            entity.HasKey(e => e.IdAcceso).HasName("PK__AccesoCl__99B2858F7F44F34C");

            entity.Property(e => e.Visible).HasDefaultValue(true);

            entity.HasOne(d => d.Clinica).WithMany(p => p.AccesoClinicasModulos)
                .HasForeignKey(d => d.ClinicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AccesoCli__Clini__00750D23");

            entity.HasOne(d => d.IdModuloNavigation).WithMany(p => p.AccesoClinicasModulos)
                .HasForeignKey(d => d.IdModulo)
                .HasConstraintName("FK_AccesoClinicasModulos_ModulosClinicas");
        });

        modelBuilder.Entity<AccionesPendientesEnfermerium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Acciones__3214EC073E885F5A");

            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Examen)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Turno)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.AccionesPendientesEnfermeria)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AccionesPendientesEnfermeria_Clinicas");

            entity.HasOne(d => d.InformeEnfermeria).WithMany(p => p.AccionesPendientesEnfermeria)
                .HasForeignKey(d => d.InformeEnfermeriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AccionesP__Infor__63A3C44B");

            entity.HasOne(d => d.idExamenNavigation).WithMany(p => p.AccionesPendientesEnfermeria)
                .HasForeignKey(d => d.idExamen)
                .HasConstraintName("FK_AccionesPendientesEnfermeria_TiposExamenesInforme");

            entity.HasOne(d => d.idTurnoNavigation).WithMany(p => p.AccionesPendientesEnfermeria)
                .HasForeignKey(d => d.idTurno)
                .HasConstraintName("FK_AccionesPendientesEnfermeria_Turnos");
        });

        modelBuilder.Entity<Almacene>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Almacene__3214EC07CCB5D1CC");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreAlmacen)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Almacenes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Almacenes_Clinicas");

            entity.HasOne(d => d.TipoAlmacen).WithMany(p => p.Almacenes)
                .HasForeignKey(d => d.TipoAlmacenId)
                .HasConstraintName("FK_Almacenes_TipoAlmacen");
        });

        modelBuilder.Entity<AntMedicamentosActuale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AntMedic__3214EC07144A4F1A");

            entity.Property(e => e.FechaInicio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntMedicamentosActuales)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntMedicamentosActuales_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntMedicamentosActuales)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__AntMedica__idCed__47C69FAC");
        });

        modelBuilder.Entity<AntecedentesAlergico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07D14BF4D7");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesAlergicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesAlergicos_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesAlergicos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__6A50C1DA");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesAlergicos)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__339FAB6E");
        });

        modelBuilder.Entity<AntecedentesAlergicos_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC070011FB06");

            entity.ToTable("AntecedentesAlergicos_HC");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesAlergicos_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesAlergicos_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesAlergicos_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__6E2152BE");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesAlergicos_HCs)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__70099B30");
        });

        modelBuilder.Entity<AntecedentesEnfermedadesInfectocontagiosasInfanca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07FE0D1036");

            entity.ToTable("AntecedentesEnfermedadesInfectocontagiosasInfanca");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesEnfermedadesInfectocontagiosasInfancas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesEnfermedadesInfectocontagiosasInfanca_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesEnfermedadesInfectocontagiosasInfancas)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__72E607DB");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesEnfermedadesInfectocontagiosasInfancas)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__2EA5EC27");
        });

        modelBuilder.Entity<AntecedentesEnfermedadesInfectocontagiosasInfancia_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC0726D77AC9");

            entity.ToTable("AntecedentesEnfermedadesInfectocontagiosasInfancia_HC");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesEnfermedadesInfectocontagiosasInfancia_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntEnfInf_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesEnfermedadesInfectocontagiosasInfancia_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__76B698BF");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesEnfermedadesInfectocontagiosasInfancia_HCs)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__789EE131");
        });

        modelBuilder.Entity<AntecedentesFamiliare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07BC8535A9");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesFamiliares)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesFamiliares_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesFamiliares)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__7B7B4DDC");

            entity.HasOne(d => d.idGeneroNavigation).WithMany(p => p.AntecedentesFamiliares)
                .HasForeignKey(d => d.idGenero)
                .HasConstraintName("FK__Anteceden__idGen__7D63964E");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesFamiliares)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__2B0A656D");

            entity.HasOne(d => d.idParentescoNavigation).WithMany(p => p.AntecedentesFamiliares)
                .HasForeignKey(d => d.idParentesco)
                .HasConstraintName("FK__Anteceden__idPar__004002F9");

            entity.HasOne(d => d.idTipoEnfermedadesNavigation).WithMany(p => p.AntecedentesFamiliares)
                .HasForeignKey(d => d.idTipoEnfermedades)
                .HasConstraintName("FK__Anteceden__idTip__02284B6B");
        });

        modelBuilder.Entity<AntecedentesFamiliares_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07ABB12CB0");

            entity.ToTable("AntecedentesFamiliares_HC");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesFamiliares_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesFamiliares_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesFamiliares_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__0504B816");

            entity.HasOne(d => d.idGeneroNavigation).WithMany(p => p.AntecedentesFamiliares_HCs)
                .HasForeignKey(d => d.idGenero)
                .HasConstraintName("FK__Anteceden__idGen__06ED0088");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesFamiliares_HCs)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__08D548FA");

            entity.HasOne(d => d.idParentescoNavigation).WithMany(p => p.AntecedentesFamiliares_HCs)
                .HasForeignKey(d => d.idParentesco)
                .HasConstraintName("FK__Anteceden__idPar__0ABD916C");

            entity.HasOne(d => d.idTipoEnfermedadesNavigation).WithMany(p => p.AntecedentesFamiliares_HCs)
                .HasForeignKey(d => d.idTipoEnfermedades)
                .HasConstraintName("FK__Anteceden__idTip__0CA5D9DE");
        });

        modelBuilder.Entity<AntecedentesGinecobstetrico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07AAB84F52");

            entity.Property(e => e.FechaAnticonceptivo).HasColumnType("datetime");
            entity.Property(e => e.FechaMenarquia).HasColumnType("datetime");
            entity.Property(e => e.MenstruacionUltimaFecha).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesGinecobstetricos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesGinecobstetricos_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesGinecobstetricos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__0F824689");

            entity.HasOne(d => d.idFrecuenciaMenstruacionNavigation).WithMany(p => p.AntecedentesGinecobstetricos)
                .HasForeignKey(d => d.idFrecuenciaMenstruacion)
                .HasConstraintName("FK__Anteceden__idFre__116A8EFB");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesGinecobstetricos)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__0697FACD");
        });

        modelBuilder.Entity<AntecedentesGinecobstetricos_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07B4922D10");

            entity.ToTable("AntecedentesGinecobstetricos_HC");

            entity.Property(e => e.FechaAnticonceptivo).HasColumnType("datetime");
            entity.Property(e => e.FechaMenarquita).HasColumnType("datetime");
            entity.Property(e => e.MenstruacionUltimaFecha).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesGinecobstetricos_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesGinecobstetricos_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesGinecobstetricos_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__153B1FDF");

            entity.HasOne(d => d.idFrecuenciaMenstruacionNavigation).WithMany(p => p.AntecedentesGinecobstetricos_HCs)
                .HasForeignKey(d => d.idFrecuenciaMenstruacion)
                .HasConstraintName("FK__Anteceden__idFre__17236851");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesGinecobstetricos_HCs)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__190BB0C3");
        });

        modelBuilder.Entity<AntecedentesHabitosPsicobiologico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07FD98F94C");

            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TabacoFechaFin).HasColumnType("datetime");
            entity.Property(e => e.TabacoFechaInicio).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesHabitosPsicobiologicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesHabitosPsicobiologicos_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesHabitosPsicobiologicos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__1BE81D6E");

            entity.HasOne(d => d.idFrecuenciaAlcoholNavigation).WithMany(p => p.AntecedentesHabitosPsicobiologicos)
                .HasForeignKey(d => d.idFrecuenciaAlcohol)
                .HasConstraintName("FK__Anteceden__idFre__1DD065E0");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesHabitosPsicobiologicos)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__690797E6");
        });

        modelBuilder.Entity<AntecedentesHabitosPsicobiologicos_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07669EAA5D");

            entity.ToTable("AntecedentesHabitosPsicobiologicos_HC");

            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.TabacoFechaFin).HasColumnType("datetime");
            entity.Property(e => e.TabacoFechaIncio).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesHabitosPsicobiologicos_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntHabitosPsico_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesHabitosPsicobiologicos_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__21A0F6C4");

            entity.HasOne(d => d.idFrecuenciaAlcoholNavigation).WithMany(p => p.AntecedentesHabitosPsicobiologicos_HCs)
                .HasForeignKey(d => d.idFrecuenciaAlcohol)
                .HasConstraintName("FK__Anteceden__idFre__23893F36");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesHabitosPsicobiologicos_HCs)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__257187A8");
        });

        modelBuilder.Entity<AntecedentesHematologico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07BCACB5E4");

            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaTransfusion).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesHematologicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesHematologicos_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesHematologicos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__284DF453");
        });

        modelBuilder.Entity<AntecedentesHematologicos_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC079E1D525A");

            entity.ToTable("AntecedentesHematologicos_HC");

            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaTransfusion).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesHematologicos_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntHematologicos_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesHematologicos_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__2B2A60FE");
        });

        modelBuilder.Entity<AntecedentesHospitalizacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC0786B08FDD");

            entity.ToTable("AntecedentesHospitalizacion");

            entity.Property(e => e.FechaHospitalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesHospitalizacions)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesHospitalizacion_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesHospitalizacions)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__2E06CDA9");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesHospitalizacions)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__5CA1C101");
        });

        modelBuilder.Entity<AntecedentesHospitalizacion_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC074EC72B06");

            entity.ToTable("AntecedentesHospitalizacion_HC");

            entity.Property(e => e.FechaHospitalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesHospitalizacion_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntHospitalizacion_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesHospitalizacion_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__31D75E8D");
        });

        modelBuilder.Entity<AntecedentesMedicamentosActuales_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07631FFA77");

            entity.ToTable("AntecedentesMedicamentosActuales_HC");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesMedicamentosActuales_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntMedicamentosActuales_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesMedicamentosActuales_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__34B3CB38");
        });

        modelBuilder.Entity<AntecedentesPersonale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC071D0EF3B7");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesPersonales)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesPersonales_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesPersonales)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__379037E3");
        });

        modelBuilder.Entity<AntecedentesPersonalesV2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07217896A8");

            entity.ToTable("AntecedentesPersonalesV2");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesPersonalesV2s)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesPersonalesV2_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesPersonalesV2s)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__3D491139");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.AntecedentesPersonalesV2s)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Anteceden__idMed__3F3159AB");
        });

        modelBuilder.Entity<AntecedentesPersonales_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07A064F62B");

            entity.ToTable("AntecedentesPersonales_HC");

            entity.Property(e => e.PostCovidDescripcion).HasMaxLength(255);
            entity.Property(e => e.VacunasDescripcion).HasMaxLength(255);

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesPersonales_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesPersonales_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesPersonales_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__3A6CA48E");
        });

        modelBuilder.Entity<AntecedentesQuirurgico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07016FFF68");

            entity.Property(e => e.FechaCirugia).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesQuirurgicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntecedentesQuirurgicos_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesQuirurgicos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__420DC656");
        });

        modelBuilder.Entity<AntecedentesQuirurgicos_HC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Antecede__3214EC07CF6AB914");

            entity.ToTable("AntecedentesQuirurgicos_HC");

            entity.Property(e => e.FechaCirugia).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.AntecedentesQuirurgicos_HCs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_AntQuirurgicos_HC_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.AntecedentesQuirurgicos_HCs)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Anteceden__idCed__44EA3301");
        });

        modelBuilder.Entity<AsientosGenerale>(entity =>
        {
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.CreadoPor).HasMaxLength(50);
            entity.Property(e => e.Credito).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Debito).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.DescripcionAsiento).HasMaxLength(50);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);

            entity.HasOne(d => d.Clinicas).WithMany(p => p.AsientosGenerales)
                .HasForeignKey(d => d.ClinicasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clinicas_PlanContableCuentas");

            entity.HasOne(d => d.PlanContableCuentas).WithMany(p => p.AsientosGenerales)
                .HasForeignKey(d => d.PlanContableCuentasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsientosGenerales_PlanContableCuentas");
        });

        modelBuilder.Entity<AsignacionesCuentasPrueba>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Asignaci__3214EC07FE0CDF69");

            entity.ToTable("AsignacionesCuentasPrueba");

            entity.Property(e => e.Activa).HasDefaultValue(true);
            entity.Property(e => e.EmailSolicitanteReal)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaExpiracion).HasColumnType("datetime");
            entity.Property(e => e.TutorialVisto).HasDefaultValue(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.AsignacionesCuentasPruebas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK__Asignacio__Clini__0DB9F9A8");

            entity.HasOne(d => d.IdCuentaPruebaNavigation).WithMany(p => p.AsignacionesCuentasPruebas)
                .HasForeignKey(d => d.IdCuentaPrueba)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignacio__IdCue__4D7F7902");
        });

        modelBuilder.Entity<BancoMonedum>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__BancoMon__3213E83FD39BDC7F");

            entity.HasOne(d => d.idBancoNavigation).WithMany(p => p.BancoMoneda)
                .HasForeignKey(d => d.idBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BancoMoneda_Banco");

            entity.HasOne(d => d.idMonedaNavigation).WithMany(p => p.BancoMoneda)
                .HasForeignKey(d => d.idMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BancoMoneda_Moneda");
        });

        modelBuilder.Entity<Baremo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Baremo__3214EC0786403BD5");

            entity.ToTable("Baremo");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Motivo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Baremos)
                .HasForeignKey(d => d.ClinicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Baremo_Clinicas");

            entity.HasOne(d => d.Seguro).WithMany(p => p.Baremos)
                .HasForeignKey(d => d.SeguroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Baremo_Seguros");

            entity.HasOne(d => d.StatusUser).WithMany(p => p.Baremos)
                .HasForeignKey(d => d.StatusUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Baremo_StatusUser");
        });

        modelBuilder.Entity<BiometricoDispositivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Biometri__3214EC0796ABB710");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Creado)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.MarcaModelo).HasMaxLength(150);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Serial).HasMaxLength(100);
            entity.Property(e => e.UltimoSyncUtc).HasPrecision(0);

            entity.HasOne(d => d.Clinica).WithMany(p => p.BiometricoDispositivos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_BiometricoDispositivos_Clinicas");
        });

        modelBuilder.Entity<BiometricoMarcaje>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Biometri__3214EC07F592B981");

            entity.HasIndex(e => e.HashIdempotencia, "UX_BiometricoMarcajes_Hash").IsUnique();

            entity.Property(e => e.CreadoUtc)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FechaHoraMarcajeUtc).HasPrecision(0);
            entity.Property(e => e.Fuente)
                .HasMaxLength(30)
                .HasDefaultValue("device");
            entity.Property(e => e.HashIdempotencia).HasMaxLength(32);
            entity.Property(e => e.TipoMarcaje).HasMaxLength(30);

            entity.HasOne(d => d.Clinica).WithMany(p => p.BiometricoMarcajes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_BiometricoMarcajes_Clinicas");

            entity.HasOne(d => d.Dispositivo).WithMany(p => p.BiometricoMarcajes)
                .HasForeignKey(d => d.DispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BiometricoMarcajes_Dispositivo");

            entity.HasOne(d => d.Usuario).WithMany(p => p.BiometricoMarcajes)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BiometricoMarcajes_Usuarios");
        });

        modelBuilder.Entity<BiometricoSyncEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Biometri__3214EC077A42746F");

            entity.ToTable("BiometricoSyncEstado");

            entity.HasIndex(e => e.AgentKey, "UX_BiometricoSyncEstado_Agent").IsUnique();

            entity.Property(e => e.AgentKey).HasMaxLength(100);
            entity.Property(e => e.CreadoUtc)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.UltimoMarcajeUtc).HasPrecision(0);
            entity.Property(e => e.UltimoPullUtc).HasPrecision(0);
            entity.Property(e => e.UltimoPushUtc).HasPrecision(0);

            entity.HasOne(d => d.Clinica).WithMany(p => p.BiometricoSyncEstados)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_BiometricoSyncEstado_Clinicas");

            entity.HasOne(d => d.Dispositivo).WithMany(p => p.BiometricoSyncEstados)
                .HasForeignKey(d => d.DispositivoId)
                .HasConstraintName("FK_BiometricoSyncEstado_Dispositivo");
        });

        modelBuilder.Entity<Cama>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Camas__3214EC076DDC4747");

            entity.Property(e => e.CodigoInterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Desde).HasColumnType("datetime");
            entity.Property(e => e.Hasta).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Paciente_ID)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrecioPorDia).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PrecioPorHora).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Prefijo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Camas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK__Camas__ClinicaId__6D2D2E85");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.Camas)
                .HasForeignKey(d => d.Habitacion_ID)
                .HasConstraintName("FK__Camas__Habitacio__55209ACA");

            entity.HasOne(d => d.ServicioDeEspacio).WithMany(p => p.Camas)
                .HasForeignKey(d => d.ServicioDeEspacioId)
                .HasConstraintName("FK__Camas__ServicioD__5708E33C");
        });

        modelBuilder.Entity<CantidadProyeccionesRayosX>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cantidad__3214EC07C2A1A347");

            entity.ToTable("CantidadProyeccionesRayosX");

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.CantidadProyeccionesRayosXes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_CantidadProyeccionesRayosX_Clinicas");
        });

        modelBuilder.Entity<CategoriaItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07C69C1D2A");

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.CategoriaItems)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_CategoriaItems_Clinicas");
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC073B870DEE");

            entity.HasIndex(e => e.NombreCategoria, "UQ__Categori__A21FBE9F3E313D95").IsUnique();

            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Categoria)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Categoria_Clinicas");
        });

        modelBuilder.Entity<CitasMedica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CitasMed__3214EC07EA0A750A");

            entity.Property(e => e.HoraCita).HasMaxLength(100);
            entity.Property(e => e.MotivoDescripcion).HasMaxLength(100);
            entity.Property(e => e.NroCaso)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComputedColumnSql("('CASO'+right('000000'+CONVERT([varchar],[ID]),(6)))", true);
            entity.Property(e => e.PorPagar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TasaCambio).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalBs).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.casoConsulta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ciPaciente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.dateCreated).HasColumnType("datetime");
            entity.Property(e => e.lastnamePaciente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.nombrePaciente)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_CitasMedicas_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idCedulaPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CitasMedi__idCed__36B12243");

            entity.HasOne(d => d.idClienteNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idCliente)
                .HasConstraintName("FK__CitasMedi__idCli__59904A2C");

            entity.HasOne(d => d.idConfirmadaNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idConfirmada)
                .HasConstraintName("FK__CitasMedi__idCon__6A50C1DA");

            entity.HasOne(d => d.idEspecialidadNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idEspecialidad)
                .HasConstraintName("FK__CitasMedi__idEsp__5D60DB10");

            entity.HasOne(d => d.idInterconsultaNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idInterconsulta)
                .HasConstraintName("FK__CitasMedi__idInt__4CF5691D");

            entity.HasOne(d => d.idItemsNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idItems)
                .HasConstraintName("FK__CitasMedi__idIte__17E28260");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.CitasMedicaidMedicoNavigations)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__CitasMedi__idMed__38996AB5");

            entity.HasOne(d => d.idMedicoInterconsultaNavigation).WithMany(p => p.CitasMedicaidMedicoInterconsultaNavigations)
                .HasForeignKey(d => d.idMedicoInterconsulta)
                .HasConstraintName("FK__CitasMedi__idMed__45544755");

            entity.HasOne(d => d.idMotivoConsultaNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idMotivoConsulta)
                .HasConstraintName("FK__CitasMedi__idMot__3A81B327");

            entity.HasOne(d => d.idStatusCasoNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idStatusCaso)
                .HasConstraintName("FK__CitasMedi__idSta__37A5467C");

            entity.HasOne(d => d.idStatusCitaNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idStatusCita)
                .HasConstraintName("FK__CitasMedi__idSta__398D8EEE");

            entity.HasOne(d => d.idStatusFacturacionNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idStatusFacturacion)
                .HasConstraintName("FK__CitasMedi__idSta__369C13AA");

            entity.HasOne(d => d.idTipoClienteNavigation).WithMany(p => p.CitasMedicas)
                .HasForeignKey(d => d.idTipoCliente)
                .HasConstraintName("FK__CitasMedi__idTip__589C25F3");

            entity.HasOne(d => d.userCreatedNavigation).WithMany(p => p.CitasMedicauserCreatedNavigations)
                .HasForeignKey(d => d.userCreated)
                .HasConstraintName("FK__CitasMedi__userC__24B26D99");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ciudad__3214EC0722EE395D");

            entity.ToTable("Ciudad");

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Ciudad_Clinicas");

            entity.HasOne(d => d.idEstadoNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.idEstado)
                .HasConstraintName("FK__Ciudad__idEstado__6A1BB7B0");
        });

        modelBuilder.Entity<ClasificacionProveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clasific__3214EC070F3D5DDD");

            entity.ToTable("ClasificacionProveedor");

            entity.Property(e => e.Clasificacion).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ClasificacionProveedors)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ClasificacionProveedor_Clinicas");
        });

        modelBuilder.Entity<ClasificacionSangre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clasific__3214EC0754BED249");

            entity.ToTable("ClasificacionSangre");

            entity.Property(e => e.Tipo).HasMaxLength(5);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ClasificacionSangres)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ClasificacionSangre_Clinicas");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC07ECB79F4F");

            entity.Property(e => e.DNI_Cliente).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Clientes_Clinicas");

            entity.HasOne(d => d.idTipoClienteNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.idTipoCliente)
                .HasConstraintName("FK__Clientes__idTipo__57A801BA");
        });

        modelBuilder.Entity<Clinica>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Clinicas__3214EC27DDD8E282");

            entity.Property(e => e.Correo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.EsClinicaPrueba).HasDefaultValue(false);
            entity.Property(e => e.ImageProfile)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rif)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCreacionId)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CondicionesProveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Condicio__3214EC0743E5F92A");

            entity.ToTable("CondicionesProveedor");

            entity.Property(e => e.Condicion).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.CondicionesProveedors)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_CondicionesProveedor_Clinicas");
        });

        modelBuilder.Entity<ConfiguracionMonedum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ConfiguracionMoneda_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CuentaPerdidaNoRealizada).IsUnicode(false);
            entity.Property(e => e.CuentaPerdidaRealizada).IsUnicode(false);
            entity.Property(e => e.CuentaUtilidadNoRealizada).IsUnicode(false);
            entity.Property(e => e.CuentaUtilidadRealizada).IsUnicode(false);
            entity.Property(e => e.MonedaContabilidad).IsUnicode(false);
            entity.Property(e => e.MonedaReporteo).IsUnicode(false);
            entity.Property(e => e.TipoCambioPredeterminado).IsUnicode(false);
        });

        modelBuilder.Entity<Configuracione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Configur__3214EC077FAFED83");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Configuraciones)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Configuraciones_Clinicas");
        });

        modelBuilder.Entity<ConsultasRemitidasMedicosInterno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Consulta__3214EC073621796F");

            entity.Property(e => e.Costo).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.FechaSolicitud)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NroInterconsulta)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasComputedColumnSql("('INTERC'+right('000000'+CONVERT([varchar],[Id]),(6)))", true);
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ConsultasRemitidasMedicosInternos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ConsultasRemitidasMedicosInternos_Clinicas");

            entity.HasOne(d => d.idAsignadaNavigation).WithMany(p => p.ConsultasRemitidasMedicosInternos)
                .HasForeignKey(d => d.idAsignada)
                .HasConstraintName("FK__Consultas__idAsi__72B0FDB1");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.ConsultasRemitidasMedicosInternos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Consultas__idCed__74994623");

            entity.HasOne(d => d.idCitaMedicaNavigation).WithMany(p => p.ConsultasRemitidasMedicosInternos)
                .HasForeignKey(d => d.idCitaMedica)
                .HasConstraintName("FK__Consultas__idCit__5A4F643B");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.ConsultasRemitidasMedicosInternos)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Consultas__idMed__5C37ACAD");
        });

        modelBuilder.Entity<CostoInforme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CostoInf__3214EC07555AF5BB");

            entity.ToTable("CostoInforme");

            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.CostoInformes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_CostoInforme_Clinicas");
        });

        modelBuilder.Entity<CostosEstadium>(entity =>
        {
            entity.HasKey(e => e.CostoId).HasName("PK__CostosEs__501474D5BBDBBC8F");

            entity.Property(e => e.CostoCalculado).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoPorDias).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoPorHoras).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DiasReales).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.FechaCalculo)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasReales).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PrecioDiaReferencia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PrecioHoraReferencia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ServicioOrigen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VersionCalculo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.CostosEstadia)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_CostosEstadia_Clinicas");

            entity.HasOne(d => d.Estadia).WithMany(p => p.CostosEstadia)
                .HasForeignKey(d => d.EstadiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CostosEst__Estad__7A521F79");
        });

        modelBuilder.Entity<CuentaSegmento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CuentaSegmentos_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Creado).HasColumnType("datetime");
        });

        modelBuilder.Entity<CuentasContable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CuentasC__3214EC077E57649A");

            entity.HasIndex(e => e.CodigoCuenta, "UQ__CuentasC__52DE76043CA05658").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoCuenta)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnType("datetime");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.CuentasContables)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK__CuentasCo__Clini__7C3A67EB");

            entity.HasOne(d => d.JerarquiaCuenta).WithMany(p => p.CuentasContables)
                .HasForeignKey(d => d.JerarquiaCuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuentasCo__Jerar__7D2E8C24");

            entity.HasOne(d => d.TipoCuenta).WithMany(p => p.CuentasContables)
                .HasForeignKey(d => d.TipoCuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CuentasCo__TipoC__7E22B05D");

            entity.HasOne(d => d.UsuarioCreador).WithMany(p => p.CuentasContableUsuarioCreadors)
                .HasForeignKey(d => d.UsuarioCreadorId)
                .HasConstraintName("FK__CuentasCo__Usuar__7F16D496");

            entity.HasOne(d => d.UsuarioModificador).WithMany(p => p.CuentasContableUsuarioModificadors)
                .HasForeignKey(d => d.UsuarioModificadorId)
                .HasConstraintName("FK__CuentasCo__Usuar__000AF8CF");
        });

        modelBuilder.Entity<DLN>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DLN__3214EC074D1A7A27");

            entity.ToTable("DLN");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.DLNs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_DLN_Clinicas");
        });

        modelBuilder.Entity<DatosExcelString>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Referencia)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinicas).WithMany(p => p.DatosExcelStrings)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_DatosExcelStrings_Clinicas");

            entity.HasOne(d => d.idBancoNavigation).WithMany(p => p.DatosExcelStrings)
                .HasForeignKey(d => d.idBanco)
                .HasConstraintName("FK_DatosExcelStrings_MaestroCuentas");
        });

        modelBuilder.Entity<DefinicionGrupoImpuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Definici__3214EC07CF537F2C");

            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.idGrupoImpuestoNavigation).WithMany(p => p.DefinicionGrupoImpuestos)
                .HasForeignKey(d => d.idGrupoImpuesto)
                .HasConstraintName("FK__Definicio__idGru__02E7657A");

            entity.HasOne(d => d.idImpuestoNavigation).WithMany(p => p.DefinicionGrupoImpuestos)
                .HasForeignKey(d => d.idImpuesto)
                .HasConstraintName("FK__Definicio__idImp__04CFADEC");

            entity.HasOne(d => d.idRetencionNavigation).WithMany(p => p.DefinicionGrupoImpuestos)
                .HasForeignKey(d => d.idRetencion)
                .HasConstraintName("FK_DefinicionGrupoImpuestos_Retenciones");
        });

        modelBuilder.Entity<DetallePresupuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DetalleP__3214EC07DA202652");

            entity.ToTable("DetallePresupuesto");

            entity.Property(e => e.Descripcion).IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.DetallePresupuestos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_DetallePresupuesto_Clinicas");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.DetallePresupuestos)
                .HasForeignKey(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallePresupuesto_Presupuesto");
        });

        modelBuilder.Entity<Diagnostico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Diagnost__3214EC077893355C");

            entity.ToTable("Diagnostico");

            entity.Property(e => e.Diagnostico1)
                .HasMaxLength(500)
                .HasColumnName("Diagnostico");
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PrefijoDepartamento).HasMaxLength(10);
            entity.Property(e => e.idNroCaso).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Diagnosticos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Diagnostico_Clinicas");

            entity.HasOne(d => d.idCedulaPcienteNavigation).WithMany(p => p.Diagnosticos)
                .HasForeignKey(d => d.idCedulaPciente)
                .HasConstraintName("FK__Diagnosti__idCed__49C3F6B7");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.Diagnosticos)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Diagnosti__idMed__4AB81AF0");
        });

        modelBuilder.Entity<DiarioAsientoManualesCabecera>(entity =>
        {
            entity.ToTable("DiarioAsientoManualesCabecera");

            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.CreadoPor).HasMaxLength(50);
            entity.Property(e => e.DescripcionDiario).HasMaxLength(50);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);

            entity.HasOne(d => d.Clinicas).WithMany(p => p.DiarioAsientoManualesCabeceras)
                .HasForeignKey(d => d.ClinicasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clinicas_DiarioAsientoManualesCabecera");
        });

        modelBuilder.Entity<DiarioAsientoManualesLinea>(entity =>
        {
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.CreadoPor).HasMaxLength(50);
            entity.Property(e => e.Credito).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.Debito).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.DescripcionAsiento).HasMaxLength(50);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);

            entity.HasOne(d => d.Clinicas).WithMany(p => p.DiarioAsientoManualesLineas)
                .HasForeignKey(d => d.ClinicasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clinicas_DiarioAsientoManualesLineas");

            entity.HasOne(d => d.IdDiarioAsientoNavigation).WithMany(p => p.DiarioAsientoManualesLineas)
                .HasForeignKey(d => d.IdDiarioAsiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiarioManualesLineas_Cabecera");

            entity.HasOne(d => d.PlanContableCuentas).WithMany(p => p.DiarioAsientoManualesLineas)
                .HasForeignKey(d => d.PlanContableCuentasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiarioManualesLineas_PlanContableCuentas");
        });

        modelBuilder.Entity<DiarioCobro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DiarioCo__3214EC07A45CFE2B");

            entity.ToTable("DiarioCobro");

            entity.Property(e => e.Clasificacion).HasMaxLength(50);
            entity.Property(e => e.CodigoFactura).HasMaxLength(50);
            entity.Property(e => e.FechaPago).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaTranscion).HasColumnType("datetime");
            entity.Property(e => e.NroFactura).HasMaxLength(50);
            entity.Property(e => e.NroFacturaAfectada).HasMaxLength(50);
            entity.Property(e => e.NroReferencia).HasMaxLength(50);
            entity.Property(e => e.Tasa).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.TotalDolares).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.DiarioCobros)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK__DiarioCo__CliId__1A1FD08D");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.DiarioCobros)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_DiarioCobro_Clinicas");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.DiarioCobros)
                .HasForeignKey(d => d.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiarioCobro_MaestroCuentas");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.DiarioCobros)
                .HasForeignKey(d => d.IdMetodoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiarioCobro_MetodoPago");
        });

        modelBuilder.Entity<DiarioPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DiarioPa__3214EC07A45CFE2B");

            entity.Property(e => e.Clasificacion).HasMaxLength(50);
            entity.Property(e => e.CodigoFactura).HasMaxLength(50);
            entity.Property(e => e.FechaPago).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaTranscion).HasColumnType("datetime");
            entity.Property(e => e.NroFactura).HasMaxLength(50);
            entity.Property(e => e.NroFacturaAfectada).HasMaxLength(50);
            entity.Property(e => e.NroReferencia).HasMaxLength(50);
            entity.Property(e => e.Tasa).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.TotalDolares).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.DiarioPagos)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_DiarioPagos_Clinicas");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.DiarioPagos)
                .HasForeignKey(d => d.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiarioPagos_MaestroCuentas");

            entity.HasOne(d => d.IdMetodoPagoNavigation).WithMany(p => p.DiarioPagos)
                .HasForeignKey(d => d.IdMetodoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiarioPagos_MetodoPago");

            entity.HasOne(d => d.idProveedorNavigation).WithMany(p => p.DiarioPagos)
                .HasForeignKey(d => d.idProveedor)
                .HasConstraintName("FK__DiarioPag__idPro__1A1FD08D");
        });

        modelBuilder.Entity<DiasPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DiasPago__3214EC076699EA6F");

            entity.ToTable("DiasPago");

            entity.Property(e => e.Dias).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.DiasPagos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_DiasPago_Clinicas");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC0745F1B383");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CasoCodigo).HasMaxLength(50);
            entity.Property(e => e.FechaSubida).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.NombreArchivoGuardado).HasMaxLength(500);
            entity.Property(e => e.NombreArchivoOriginal).HasMaxLength(255);
            entity.Property(e => e.RutaArchivo).HasMaxLength(1000);
            entity.Property(e => e.TipoContenido).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Documentos_Clinicas");

            entity.HasOne(d => d.Paciente).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documentos_Pacientes");

            entity.HasOne(d => d.UsuarioSubida).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.UsuarioSubidaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documentos_Usuarios");
        });

        modelBuilder.Entity<EnfermedadActual>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enfermed__3214EC0733EE35C6");

            entity.ToTable("EnfermedadActual");

            entity.Property(e => e.EnfActual).HasMaxLength(500);
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PrefijoDepartamento).HasMaxLength(10);
            entity.Property(e => e.idNroCaso)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.EnfermedadActuals)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_EnfermedadActual_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.EnfermedadActuals)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Enfermeda__idCed__1CA7377D");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.EnfermedadActuals)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Enfermeda__idMed__5441852A");
        });

        modelBuilder.Entity<Especialidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Especial__3214EC07F17087E1");

            entity.Property(e => e.CostoConsulta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Especialidad).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Especialidades)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Especialidades_Clinicas");

            entity.HasOne(d => d.idTipoIVANavigation).WithMany(p => p.Especialidades)
                .HasForeignKey(d => d.idTipoIVA)
                .HasConstraintName("FK__Especiali__idTip__2077C861");
        });

        modelBuilder.Entity<EspecialidadesMedico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Especial__3214EC07FBCD5F52");

            entity.HasOne(d => d.Clinica).WithMany(p => p.EspecialidadesMedicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_EspecialidadesMedicos_Clinicas");

            entity.HasOne(d => d.idEspecialidadNavigation).WithMany(p => p.EspecialidadesMedicos)
                .HasForeignKey(d => d.idEspecialidad)
                .HasConstraintName("FK__Especiali__idEsp__2354350C");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.EspecialidadesMedicos)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Especiali__idMed__253C7D7E");
        });

        modelBuilder.Entity<EstadiaPaciente>(entity =>
        {
            entity.HasKey(e => e.EstadiaId).HasName("PK__EstadiaP__C284B62532E2A641");

            entity.ToTable("EstadiaPaciente");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Creado).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EsTransferencia).HasDefaultValue(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Notas)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PrecioCalculadoPorDia).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PrecioCalculadoPorHora).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TipoEstadia)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalCalculado).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Cama).WithMany(p => p.EstadiaPacientes)
                .HasForeignKey(d => d.CamaId)
                .HasConstraintName("FK__EstadiaPa__CamaI__2818EA29");

            entity.HasOne(d => d.Clinica).WithMany(p => p.EstadiaPacientes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_EstadiaPaciente_Clinicas");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.EstadiaPacientes)
                .HasForeignKey(d => d.HabitacionId)
                .HasConstraintName("FK__EstadiaPa__Habit__290D0E62");

            entity.HasOne(d => d.Paciente).WithMany(p => p.EstadiaPacientes)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EstadiaPa__Pacie__2A01329B");

            entity.HasOne(d => d.ReservaEmergencia).WithMany(p => p.EstadiaPacientes)
                .HasForeignKey(d => d.ReservaEmergenciaId)
                .HasConstraintName("FK_Estadia_ReservaEmergencia");

            entity.HasOne(d => d.ReservaHospitalizacion).WithMany(p => p.EstadiaPacientes)
                .HasForeignKey(d => d.ReservaHospitalizacionId)
                .HasConstraintName("FK_Estadia_ReservaHospitalizacion");

            entity.HasOne(d => d.TransferenciaDesdeNavigation).WithMany(p => p.InverseTransferenciaDesdeNavigation)
                .HasForeignKey(d => d.TransferenciaDesde)
                .HasConstraintName("FK__EstadiaPa__Trans__2AF556D4");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estado__3214EC0785587F0D");

            entity.ToTable("Estado");

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Estados)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Estado_Clinicas");
        });

        modelBuilder.Entity<EstadoCirugium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstadoCi__3214EC07D5C59654");

            entity.HasIndex(e => e.Nombre, "UQ__EstadoCi__75E3EFCF85B635A9").IsUnique();

            entity.Property(e => e.Color).HasMaxLength(7);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<EstadoCivil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstadoCi__3214EC078B83CA7D");

            entity.ToTable("EstadoCivil");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.EstadoCivils)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_EstadoCivil_Clinicas");
        });

        modelBuilder.Entity<EstadoCuentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstadoCu__3214EC07FA268DFA");

            entity.Property(e => e.CodigoFactura).HasMaxLength(50);
            entity.Property(e => e.NroFactura).HasMaxLength(50);
            entity.Property(e => e.TotalCompleto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.EstadoCuenta)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_EstadoCuenta_Clientes");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.EstadoCuenta)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_EstadoCuenta_Clinicas");
        });

        modelBuilder.Entity<EstadoOrdenSeguro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstadoOr__3214EC07D3EA03B2");

            entity.ToTable("EstadoOrdenSeguro");

            entity.HasOne(d => d.Clinica).WithMany(p => p.EstadoOrdenSeguros)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_EstadoOrdenSeguro_Clinicas");
        });

        modelBuilder.Entity<EstadoSintoma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EstadoSi__3214EC07D8F5D6B7");

            entity.ToTable("EstadoSintoma");

            entity.Property(e => e.Estado).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.EstadoSintomas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_EstadoSintoma_Clinicas");
        });

        modelBuilder.Entity<EstructurasContable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EstructurasContables_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo).IsUnicode(false);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.Nombre).IsUnicode(false);
        });

        modelBuilder.Entity<Estudio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estudios__3214EC0758770496");

            entity.Property(e => e.FechaRegistroFactProveedor).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.OrdenEstudioSeguro).HasMaxLength(100);
            entity.Property(e => e.PorPagar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TasaCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDivisas).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Estudios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Estudios_Clinicas");

            entity.HasOne(d => d.idCantidadProyeccionesRayosXNavigation).WithMany(p => p.Estudios)
                .HasForeignKey(d => d.idCantidadProyeccionesRayosX)
                .HasConstraintName("FK__Estudios__idCant__0F824689");

            entity.HasOne(d => d.idCategoriaItemsNavigation).WithMany(p => p.Estudios)
                .HasForeignKey(d => d.idCategoriaItems)
                .HasConstraintName("FK__Estudios__idCate__18D6A699");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.Estudios)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Estudios__idCedu__74CE504D");

            entity.HasOne(d => d.idClinetesNavigation).WithMany(p => p.Estudios)
                .HasForeignKey(d => d.idClinetes)
                .HasConstraintName("FK__Estudios__idClin__18178C8A");

            entity.HasOne(d => d.idItemsNavigation).WithMany(p => p.Estudios)
                .HasForeignKey(d => d.idItems)
                .HasConstraintName("FK__Estudios__idItem__3C1FE2D6");

            entity.HasOne(d => d.idStatusFacturacionNavigation).WithMany(p => p.Estudios)
                .HasForeignKey(d => d.idStatusFacturacion)
                .HasConstraintName("FK__Estudios__idStat__379037E3");

            entity.HasOne(d => d.idTipoClienteNavigation).WithMany(p => p.Estudios)
                .HasForeignKey(d => d.idTipoCliente)
                .HasConstraintName("FK__Estudios__idTipo__17236851");

            entity.HasOne(d => d.idTipoRayosXNavigation).WithMany(p => p.Estudios)
                .HasForeignKey(d => d.idTipoRayosX)
                .HasConstraintName("FK__Estudios__idTipo__0E8E2250");
        });

        modelBuilder.Entity<EstudiosCabecera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estudios__3214EC07CFF7791A");

            entity.ToTable("EstudiosCabecera");

            entity.Property(e => e.CorreoElectronico).HasMaxLength(200);
            entity.Property(e => e.InformePDF).HasMaxLength(100);
            entity.Property(e => e.PDFFactura).HasMaxLength(100);
            entity.Property(e => e.PDFOrden).HasMaxLength(100);
            entity.Property(e => e.PorPagar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalBs).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.TotalDivisas).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.EstudiosCabeceras)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_EstudiosCabecera_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.EstudiosCabeceras)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__EstudiosC__idCed__3D14070F");

            entity.HasOne(d => d.idClienteNavigation).WithMany(p => p.EstudiosCabeceras)
                .HasForeignKey(d => d.idCliente)
                .HasConstraintName("FK__EstudiosC__idCli__53F76C67");

            entity.HasOne(d => d.idStatusFacturacionNavigation).WithMany(p => p.EstudiosCabeceras)
                .HasForeignKey(d => d.idStatusFacturacion)
                .HasConstraintName("FK__EstudiosC__idSta__3FF073BA");

            entity.HasOne(d => d.idTipoClienteNavigation).WithMany(p => p.EstudiosCabeceras)
                .HasForeignKey(d => d.idTipoCliente)
                .HasConstraintName("FK__EstudiosC__idTip__41D8BC2C");
        });

        modelBuilder.Entity<EstudiosDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estudios__3214EC0701B979C2");

            entity.ToTable("EstudiosDetalle");

            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.EstudiosDetalles)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_EstudiosDetalle_Clinicas");

            entity.HasOne(d => d.idCantidadProyeccionesRayosXNavigation).WithMany(p => p.EstudiosDetalles)
                .HasForeignKey(d => d.idCantidadProyeccionesRayosX)
                .HasConstraintName("FK__EstudiosD__idCan__5AA469F6");

            entity.HasOne(d => d.idCategoriaItemsNavigation).WithMany(p => p.EstudiosDetalles)
                .HasForeignKey(d => d.idCategoriaItems)
                .HasConstraintName("FK__EstudiosD__idCat__57C7FD4B");

            entity.HasOne(d => d.idItemsNavigation).WithMany(p => p.EstudiosDetalles)
                .HasForeignKey(d => d.idItems)
                .HasConstraintName("FK__EstudiosD__idIte__58BC2184");

            entity.HasOne(d => d.idTipoRayosXNavigation).WithMany(p => p.EstudiosDetalles)
                .HasForeignKey(d => d.idTipoRayosX)
                .HasConstraintName("FK__EstudiosD__idTip__59B045BD");
        });

        modelBuilder.Entity<EvolucionesEnfermerium>(entity =>
        {
            entity.Property(e => e.FechaHoraRegistro).HasColumnType("datetime");
            entity.Property(e => e.NombreEnfermera).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.EvolucionesEnfermeria)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_EvolucionesEnfermeria_Clinicas");

            entity.HasOne(d => d.InformeEnfermeria).WithMany(p => p.EvolucionesEnfermeria)
                .HasForeignKey(d => d.InformeEnfermeriaId)
                .HasConstraintName("FK_EvolucionesEnfermeria_InformeEnfermeria");
        });

        modelBuilder.Entity<ExamenFisico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ExamenFi__3214EC07BCFBC3BE");

            entity.ToTable("ExamenFisico");

            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FisicoAspectoGeneral)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FrecuenciaCardiaca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FrecuenciaRespiratoria)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Peso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrefijoDepartamento).HasMaxLength(10);
            entity.Property(e => e.Talla)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Temperatura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TensionArterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.idNroCaso)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ExamenFisicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ExamenFisico_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.ExamenFisicos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__ExamenFis__idCed__511AFFBC");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.ExamenFisicos)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__ExamenFis__idMed__5AEE82B9");
        });

        modelBuilder.Entity<ExamenFisico2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ExamenFi__3214EC079E52E83C");

            entity.ToTable("ExamenFisico2");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.idNroCaso)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ExamenFisico2s)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ExamenFisico2_Clinicas");

            entity.HasOne(d => d.ExamenFisico).WithMany(p => p.ExamenFisico2s)
                .HasForeignKey(d => d.ExamenFisicoId)
                .HasConstraintName("FK_ExamenFisico2_Examenfisico");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.ExamenFisico2s)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__ExamenFis__idCed__54EB90A0");

            entity.HasOne(d => d.idDLNNavigation).WithMany(p => p.ExamenFisico2s)
                .HasForeignKey(d => d.idDLN)
                .HasConstraintName("FK__ExamenFis__idDLN__56D3D912");

            entity.HasOne(d => d.idExamenes_ExamenFisicoNavigation).WithMany(p => p.ExamenFisico2s)
                .HasForeignKey(d => d.idExamenes_ExamenFisico)
                .HasConstraintName("FK__ExamenFis__idExa__58BC2184");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.ExamenFisico2s)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__ExamenFis__idMed__656C112C");

            entity.HasOne(d => d.idZonaExamenFisicoNavigation).WithMany(p => p.ExamenFisico2s)
                .HasForeignKey(d => d.idZonaExamenFisico)
                .HasConstraintName("FK__ExamenFis__idZon__5B988E2F");
        });

        modelBuilder.Entity<Examene>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Examenes__3214EC0737FB6F16");

            entity.Property(e => e.Examen).HasMaxLength(50);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Examenes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Examenes_Clinicas");

            entity.HasOne(d => d.idTipoExamenNavigation).WithMany(p => p.Examenes)
                .HasForeignKey(d => d.idTipoExamen)
                .HasConstraintName("FK__Examenes__idTipo__0F2D40CE");

            entity.HasOne(d => d.idTipoIVANavigation).WithMany(p => p.Examenes)
                .HasForeignKey(d => d.idTipoIVA)
                .HasConstraintName("FK__Examenes__idTipo__4C564A9F");
        });

        modelBuilder.Entity<ExamenesParaclinico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Examenes__3214EC077A4F0C9C");

            entity.Property(e => e.Examen).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ExamenesParaclinicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ExamenesParaclinicos_Clinicas");
        });

        modelBuilder.Entity<Examenes_ExamenFisico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Examenes__3214EC07EE6082BF");

            entity.ToTable("Examenes_ExamenFisico");

            entity.Property(e => e.Examen)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Examenes_ExamenFisicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Examenes_ExamenFisico_Clinicas");
        });

        modelBuilder.Entity<FactorRH>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FactorRH__3214EC07C90EE534");

            entity.ToTable("FactorRH");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.FactorRHs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_FactorRH_Clinicas");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Facturas__3214EC079106FCCA");

            entity.Property(e => e.BaseImponible).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseImponibleExenta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Conciliado).HasDefaultValue(false);
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaOperacion).HasColumnType("datetime");
            entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.IGTF).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.IVA).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TasaCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_Facturas_Clientes");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Facturas_Clinicas");

            entity.HasOne(d => d.IdProveedoresNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdProveedores)
                .HasConstraintName("FK_Facturas_Proveedores");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdTipoDocumento)
                .HasConstraintName("FK_Facturas_TipoDocumento");

            entity.HasOne(d => d.OrdenCompra).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.OrdenCompraId)
                .HasConstraintName("FK_Facturas_OrdenCompraId");

            entity.HasOne(d => d.Paciente).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.PacienteId)
                .HasConstraintName("FK_facturas_Pacientes");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.PresupuestoId)
                .HasConstraintName("FK_Facturas_PresupuestoId");

            entity.HasOne(d => d.SegurosPacientes).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.SegurosPacientesId)
                .HasConstraintName("FK_Facturas_SegurosPacientesId");

            entity.HasOne(d => d.Servicio).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("FK_facturas_Servicios");

            entity.HasOne(d => d.idStatusFacturacionNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.idStatusFacturacion)
                .HasConstraintName("FK__Facturas__idStat__605D434C");

            entity.HasOne(d => d.idTipoFacturaNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.idTipoFactura)
                .HasConstraintName("FK_Facturas_TipoFactura");
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormaPag__3214EC0724C06514");

            entity.ToTable("FormaPago");

            entity.Property(e => e.Forma).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.FormaPagos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_FormaPago_Clinicas");
        });

        modelBuilder.Entity<FormasPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FormasPa__3214EC073D52E4EC");

            entity.ToTable("FormasPago");

            entity.Property(e => e.Forma).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.FormasPagos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_FormasPago_Clinicas");
        });

        modelBuilder.Entity<FrecuenciaMenstruacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Frecuenc__3214EC07039C4933");

            entity.ToTable("FrecuenciaMenstruacion");

            entity.Property(e => e.Frecuencia).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.FrecuenciaMenstruacions)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_FrecuenciaMenstruacion_Clinicas");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Genero__3214EC072B32AB59");

            entity.ToTable("Genero");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Generos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Genero_Clinicas");
        });

        modelBuilder.Entity<GrupoArticulo>(entity =>
        {
            entity.ToTable("GrupoArticulo");

            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.NombreGrupoArticulo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.GrupoArticulos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_GrupoArticulo_Clinicas");
        });

        modelBuilder.Entity<GrupoDeImpuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GrupoDeI__3214EC070F034B16");

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Grupo).HasMaxLength(50);

            entity.HasOne(d => d.Clinicas).WithMany(p => p.GrupoDeImpuestos)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_GrupoDeImpuestos_Clinicas");
        });

        modelBuilder.Entity<GruposCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GruposClientes_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<GruposProveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GruposProveedores_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<Habitacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Habitaci__3214EC077A7D83C3");

            entity.Property(e => e.Desde).HasColumnType("datetime");
            entity.Property(e => e.Hasta).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrecioPorDia).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PrecioPorHora).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Prefijo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Habitaciones)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK__Habitacio__Clini__71BCD978");

            entity.HasOne(d => d.Piso).WithMany(p => p.Habitaciones)
                .HasForeignKey(d => d.Piso_ID)
                .HasConstraintName("FK__Habitacio__Piso___75586032");

            entity.HasOne(d => d.ServicioDeEspacio).WithMany(p => p.Habitaciones)
                .HasForeignKey(d => d.ServicioDeEspacioId)
                .HasConstraintName("FK__Habitacio__Servi__7740A8A4");
        });

        modelBuilder.Entity<HistoriaClinica>(entity =>
        {
            entity.HasKey(e => e.HistoriaClinicaId).HasName("PK__Historia__989801DF21D0828B");

            entity.ToTable("HistoriaClinica");

            entity.Property(e => e.FC).HasMaxLength(10);
            entity.Property(e => e.FR).HasMaxLength(10);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.SATO2).HasMaxLength(10);
            entity.Property(e => e.TA).HasMaxLength(10);

            entity.HasOne(d => d.Clinica).WithMany(p => p.HistoriaClinicas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_HistoriaClinica_Clinicas");

            entity.HasOne(d => d.Paciente).WithMany(p => p.HistoriaClinicas)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HistoriaC__Pacie__5A3A55A2");
        });

        modelBuilder.Entity<HistoriaMotivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historia__3214EC07D7AD2E71");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.HistoriaMotivos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_HistoriaMotivos_Clinicas");
        });

        modelBuilder.Entity<HistoriaOcupacional>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historia__3214EC07A47D922C");

            entity.ToTable("HistoriaOcupacional");

            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.idNroCaso).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.HistoriaOcupacionals)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_HistoriaOcupacional_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.HistoriaOcupacionals)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__HistoriaO__idCed__03A67F89");

            entity.HasOne(d => d.idEstadoEvaluacionMedicaNavigation).WithMany(p => p.HistoriaOcupacionals)
                .HasForeignKey(d => d.idEstadoEvaluacionMedica)
                .HasConstraintName("FK__HistoriaO__idEst__058EC7FB");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.HistoriaOcupacionals)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__HistoriaO__idMed__753864A1");
        });

        modelBuilder.Entity<HistorialConversionesUnidade>(entity =>
        {
            entity.Property(e => e.FactorUtilizado).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.FechaHoraConversion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.ResultadoConvertido).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ValorEntrada).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.HistorialConversionesUnidades)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_HistorialConvUnid_Clinicas");

            entity.HasOne(d => d.Producto).WithMany(p => p.HistorialConversionesUnidades)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_HistorialConversionesUnidades_Producto");

            entity.HasOne(d => d.ReglaConversionUnidad).WithMany(p => p.HistorialConversionesUnidades)
                .HasForeignKey(d => d.ReglaConversionUnidadId)
                .HasConstraintName("FK_HistorialConversionesUnidades_ReglaConversion");

            entity.HasOne(d => d.UnidadMedidaDestino).WithMany(p => p.HistorialConversionesUnidadeUnidadMedidaDestinos)
                .HasForeignKey(d => d.UnidadMedidaDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialConversionesUnidades_UnidadDestino");

            entity.HasOne(d => d.UnidadMedidaOrigen).WithMany(p => p.HistorialConversionesUnidadeUnidadMedidaOrigens)
                .HasForeignKey(d => d.UnidadMedidaOrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialConversionesUnidades_UnidadOrigen");
        });

        modelBuilder.Entity<HistorialEvolucion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historia__3214EC07C51E4BB0");

            entity.ToTable("HistorialEvolucion");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PrefijoDepartamento).HasMaxLength(10);
            entity.Property(e => e.Profesional).HasMaxLength(255);
            entity.Property(e => e.idMedico).HasMaxLength(128);
            entity.Property(e => e.idNroCaso)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.HistorialEvolucions)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_HistorialEvolucion_Clinicas");

            entity.HasOne(d => d.InformeMedico).WithMany(p => p.HistorialEvolucions)
                .HasForeignKey(d => d.InformeMedicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__Infor__00CA12DE");
        });

        modelBuilder.Entity<HistorialImpuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historia__3214EC07CB81C1B1");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Valor).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Honorario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Honorari__3214EC07F3E7C88E");

            entity.ToTable("Honorario");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Honorarios)
                .HasForeignKey(d => d.ClinicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Honorario_Clinicas");

            entity.HasOne(d => d.Proveedores).WithMany(p => p.Honorarios)
                .HasForeignKey(d => d.ProveedoresId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Honorario_Proveedores");

            entity.HasOne(d => d.StatusUser).WithMany(p => p.Honorarios)
                .HasForeignKey(d => d.StatusUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Honorario_StatusUser");
        });

        modelBuilder.Entity<HonorarioBaremo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Honorari__3214EC07A1FBD62A");

            entity.ToTable("HonorarioBaremo");

            entity.HasOne(d => d.Baremo).WithMany(p => p.HonorarioBaremos)
                .HasForeignKey(d => d.BaremoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HonorarioBaremo_Baremo");

            entity.HasOne(d => d.Clinica).WithMany(p => p.HonorarioBaremos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_HonorarioBaremo_Clinicas");

            entity.HasOne(d => d.Honorario).WithMany(p => p.HonorarioBaremos)
                .HasForeignKey(d => d.HonorarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HonorarioBaremo_Honorario");
        });

        modelBuilder.Entity<Imagene>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Imagenes__3214EC0739FD5F86");

            entity.HasOne(d => d.Servicios).WithMany(p => p.Imagenes)
                .HasForeignKey(d => d.ServiciosId)
                .HasConstraintName("FK__Imagenes__Servic__0F183235");
        });

        modelBuilder.Entity<Impuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Impuesto__3214EC07D179B745");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Maximo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Minimo).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Impuestos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK__Impuestos__Clini__0D64F3ED");
        });

        modelBuilder.Entity<ImpuestoServicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Impuesto__3214EC075EFAD815");

            entity.Property(e => e.CodigoImpuesto)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TotalImpuesto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorImpuesto).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.ImpuestoServicios)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImpuestoS__IdImp__11F49EE0");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ImpuestoServicios)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImpuestoS__IdSer__12E8C319");
        });

        modelBuilder.Entity<ImpuestosFactura>(entity =>
        {
            entity.HasKey(e => new { e.CodigoFactura, e.IdImpuesto });

            entity.Property(e => e.CodigoFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoImpuesto)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorImpuesto).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.ImpuestosFacturas)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_ImpuestosFacturas_Clinicas");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.ImpuestosFacturas)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ImpuestosFacturas_Facturas");

            entity.HasOne(d => d.IdImpuestoNavigation).WithMany(p => p.ImpuestosFacturas)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImpuestosFacturas_Impuestos");
        });

        modelBuilder.Entity<ImpuestosItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Impuesto__3214EC0726E6C1B4");

            entity.HasOne(d => d.idImpuestoNavigation).WithMany(p => p.ImpuestosItems)
                .HasForeignKey(d => d.idImpuesto)
                .HasConstraintName("FK_ImpuestosItems_Impuestos");

            entity.HasOne(d => d.idItemsNavigation).WithMany(p => p.ImpuestosItems)
                .HasForeignKey(d => d.idItems)
                .HasConstraintName("FK_ImpuestosItems_Items");
        });

        modelBuilder.Entity<ImpuestosRetencione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Impuesto__3214EC07F26EE5F6");

            entity.Property(e => e.CodigoImpuesto).HasMaxLength(20);
        });

        modelBuilder.Entity<IndicacionesTerapeutica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Indicaci__3214EC07D41F0891");

            entity.Property(e => e.Aprobado).HasDefaultValue(false);
            entity.Property(e => e.Dosis).HasMaxLength(50);
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Indicaciones).HasMaxLength(500);
            entity.Property(e => e.NombreRegente).HasMaxLength(50);
            entity.Property(e => e.PrefijoDepartamento).HasMaxLength(10);
            entity.Property(e => e.idNroCaso).HasMaxLength(500);

            entity.HasOne(d => d.Clinica).WithMany(p => p.IndicacionesTerapeuticas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_IndicacionesTerapeuticas_Clinicas");

            entity.HasOne(d => d.Producto).WithMany(p => p.IndicacionesTerapeuticas)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_IndicacionesTerapeuticas_Productos");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.IndicacionesTerapeuticas)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Indicacio__idCed__18A19C6F");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.IndicacionesTerapeuticas)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Indicacio__idMed__75A278F5");

            entity.HasOne(d => d.idViaAdministracionNavigation).WithMany(p => p.IndicacionesTerapeuticas)
                .HasForeignKey(d => d.idViaAdministracion)
                .HasConstraintName("FK__Indicacio__idVia__1B7E091A");
        });

        modelBuilder.Entity<InfoAlcohol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InfoAlco__3214EC070EE753D8");

            entity.ToTable("InfoAlcohol");

            entity.Property(e => e.Info).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.InfoAlcohols)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_InfoAlcohol_Clinicas");
        });

        modelBuilder.Entity<InfoConsumo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InfoCons__3214EC074C661EAE");

            entity.ToTable("InfoConsumo");

            entity.Property(e => e.Info).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.InfoConsumos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_InfoConsumo_Clinicas");
        });

        modelBuilder.Entity<InfoEjercicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InfoEjer__3214EC077ED37715");

            entity.ToTable("InfoEjercicio");

            entity.Property(e => e.Info).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.InfoEjercicios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_InfoEjercicio_Clinicas");
        });

        modelBuilder.Entity<InfoTabaco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InfoTaba__3214EC074F8106FF");

            entity.ToTable("InfoTabaco");

            entity.Property(e => e.Info).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.InfoTabacos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_InfoTabaco_Clinicas");
        });

        modelBuilder.Entity<InformeEnfermerium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InformeE__3214EC0758427C64");

            entity.Property(e => e.DietaPaciente).IsUnicode(false);
            entity.Property(e => e.EnfermeraTurno)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaHoraEgreso).HasColumnType("datetime");
            entity.Property(e => e.HemodTurno)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HoraEgresoA)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NeuroTurno)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PielMucosaTurno)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrefijoDepartamento).HasMaxLength(10);
            entity.Property(e => e.RenalTurno)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TurnoEnfermeria)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.idNroCaso)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.InformeEnfermeria)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_InformeEnfermeria_Clinicas");

            entity.HasOne(d => d.Paciente).WithMany(p => p.InformeEnfermeria)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__InformeEn__Pacie__222B06A9");

            entity.HasOne(d => d.idTurnoPrincipalNavigation).WithMany(p => p.InformeEnfermeria)
                .HasForeignKey(d => d.idTurnoPrincipal)
                .HasConstraintName("FK_InformeEnfermeria_Turnos");
        });

        modelBuilder.Entity<InformeMedico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__InformeM__3214EC077E89632C");

            entity.ToTable("InformeMedico");

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IncluirExamenesRealizados).HasDefaultValue(false);
            entity.Property(e => e.PrefijoDepartamento).HasMaxLength(10);
            entity.Property(e => e.SolicitudAtendida).HasDefaultValue(false);
            entity.Property(e => e.idNroCaso).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.InformeMedicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_InformeMedico_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.InformeMedicos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__InformeMe__idCed__25FB978D");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.InformeMedicos)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__InformeMe__idMed__7A672E12");

            entity.HasOne(d => d.idTipoInformeNavigation).WithMany(p => p.InformeMedicos)
                .HasForeignKey(d => d.idTipoInforme)
                .HasConstraintName("FK_InformeMedico_TipoInformeMedico");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Inventar__3214EC07DCDAEBC5");

            entity.ToTable("Inventario");

            entity.HasIndex(e => new { e.ProductoId, e.UbicacionId, e.LoteProductoId }, "UQ_Inventario_ProductoId_UbicacionId_LoteProductoId").IsUnique();

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.CostoPromedioUnitario).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StockMinimo).HasDefaultValue(0);
            entity.Property(e => e.ValorTotalInventario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Inventario_Clinicas");

            entity.HasOne(d => d.LoteProducto).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.LoteProductoId)
                .HasConstraintName("FK_Inventario_LotesProducto");

            entity.HasOne(d => d.Producto).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventario_Productos");

            entity.HasOne(d => d.Ubicacion).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.UbicacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inventario_Ubicaciones");
        });

        modelBuilder.Entity<InventarioFisico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Inventar__3214EC0716718DC4");

            entity.ToTable("InventarioFisico");

            entity.Property(e => e.Comentarios).HasColumnType("text");
            entity.Property(e => e.FechaConteo)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.InventarioFisicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_InventarioFisico_Clinicas");

            entity.HasOne(d => d.Inventario).WithMany(p => p.InventarioFisicos)
                .HasForeignKey(d => d.InventarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventarioFisico_Inventario");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Items__3214EC07414899FC");

            entity.Property(e => e.CostoParticular).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoSeguro).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Items)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Items_Clinicas");

            entity.HasOne(d => d.idCategoriaItemsNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.idCategoriaItems)
                .HasConstraintName("FK__Items__idCategor__150615B5");

            entity.HasOne(d => d.idClientesNavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.idClientes)
                .HasConstraintName("FK__Items__idCliente__3572E547");

            entity.HasOne(d => d.idTipoIVANavigation).WithMany(p => p.Items)
                .HasForeignKey(d => d.idTipoIVA)
                .HasConstraintName("FK__Items__idTipoIVA__16EE5E27");
        });

        modelBuilder.Entity<JerarquiaCuentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Jerarqui__3214EC07F3F72973");

            entity.HasIndex(e => e.CodigoJerarquia, "UQ__Jerarqui__B7F3F7D85E85A9A8").IsUnique();

            entity.Property(e => e.CodigoJerarquia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPadre)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnType("datetime");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.JerarquiaCuenta)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK__Jerarquia__Clini__353DDB1D");

            entity.HasOne(d => d.UsuarioCreador).WithMany(p => p.JerarquiaCuentumUsuarioCreadors)
                .HasForeignKey(d => d.UsuarioCreadorId)
                .HasConstraintName("FK__Jerarquia__Usuar__3631FF56");

            entity.HasOne(d => d.UsuarioModificador).WithMany(p => p.JerarquiaCuentumUsuarioModificadors)
                .HasForeignKey(d => d.UsuarioModificadorId)
                .HasConstraintName("FK__Jerarquia__Usuar__3726238F");
        });

        modelBuilder.Entity<LineasEstuduio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LineasEs__3214EC0707F33A96");

            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Proyecciones).HasMaxLength(50);
            entity.Property(e => e.idCategoriaItems).HasMaxLength(50);
            entity.Property(e => e.idItems).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.LineasEstuduios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_LineasEstuduios_Clinicas");
        });

        modelBuilder.Entity<LineasServicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LineasSe__3214EC07B081F6B8");

            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.LineasServicios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_LineasServicios_Clinicas");
        });

        modelBuilder.Entity<LogErrorsTrace>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LogError__3214EC07C3A5EA78");

            entity.ToTable("LogErrorsTrace");

            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.LogErrorsTraces)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_LogErrorsTrace_Clinicas");
        });

        modelBuilder.Entity<LotesProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LotesPro__3214EC0733B7607E");

            entity.ToTable("LotesProducto");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NumeroLote)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.LotesProductos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_LotesProducto_Clinicas");

            entity.HasOne(d => d.Producto).WithMany(p => p.LotesProductos)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LotesProducto_Productos");

            entity.HasOne(d => d.Ubicacion).WithMany(p => p.LotesProductos)
                .HasForeignKey(d => d.UbicacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LotesProducto_Ubicaciones");
        });

        modelBuilder.Entity<MaestroCuenta>(entity =>
        {
            entity.Property(e => e.Banco).HasMaxLength(100);
            entity.Property(e => e.NrDocumento).HasMaxLength(20);
            entity.Property(e => e.NumeroCuenta).HasMaxLength(100);
            entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.MaestroCuenta)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_MaestroCuentas_Clinicas");

            entity.HasOne(d => d.TipoDocumentoNavigation).WithMany(p => p.MaestroCuenta)
                .HasForeignKey(d => d.TipoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaestroCuentas_TipoDocumentacion");

            entity.HasOne(d => d.idTipoBancoNavigation).WithMany(p => p.MaestroCuenta)
                .HasForeignKey(d => d.idTipoBanco)
                .HasConstraintName("FK_MaestroCuentas_TipoBanco");
        });

        modelBuilder.Entity<MedicamentoFormula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Medicame__3214EC07A53106AC");

            entity.ToTable("MedicamentoFormula");

            entity.Property(e => e.Dosis).HasMaxLength(50);

            entity.HasOne(d => d.Formula).WithMany(p => p.MedicamentoFormulas)
                .HasForeignKey(d => d.FormulaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicamentoFormula_FormulaMedica");

            entity.HasOne(d => d.Producto).WithMany(p => p.MedicamentoFormulas)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicamentoFormula_Productos");
        });

        modelBuilder.Entity<MetodoCosteo>(entity =>
        {
            entity.ToTable("MetodoCosteo");

            entity.HasIndex(e => e.NombreMetodo, "UQ__MetodoCo__EDA0070F7E0733E5").IsUnique();

            entity.HasIndex(e => e.NombreMetodo, "UQ__MetodoCo__EDA0070FF34E3C04").IsUnique();

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.NombreMetodo).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.MetodoCosteos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_MetodoCosteo_Clinicas");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MetodoPa__3214EC07E0111913");

            entity.ToTable("MetodoPago");

            entity.Property(e => e.Tipo).HasMaxLength(50);
        });

        modelBuilder.Entity<Modulo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Modulos__3214EC075174B0BE");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Modulos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Modulos_Clinicas");
        });

        modelBuilder.Entity<ModulosClinica>(entity =>
        {
            entity.HasKey(e => e.IdModulo).HasName("PK__ModulosC__D9F153150E812219");

            entity.Property(e => e.Area).HasMaxLength(50);
            entity.Property(e => e.Controller).HasMaxLength(100);
            entity.Property(e => e.Dependencia).HasMaxLength(50);
            entity.Property(e => e.Icono).HasMaxLength(50);
            entity.Property(e => e.Metodo).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Visible).HasDefaultValue(true);

            entity.HasOne(d => d.IdModuloPadreNavigation).WithMany(p => p.InverseIdModuloPadreNavigation)
                .HasForeignKey(d => d.IdModuloPadre)
                .HasConstraintName("FK_ModulosClinicas_Padre");
        });

        modelBuilder.Entity<Monedum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Moneda__3214EC076C0C7311");

            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Moneda)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Moneda_Clinicas");
        });

        //modelBuilder.Entity<Monitor>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__Monitor__3214EC0727013DA6");

        //    entity.ToTable("Monitor");

        //    entity.HasOne(d => d.Clinica).WithMany(p => p.Monitors)
        //        .HasForeignKey(d => d.ClinicaId)
        //        .HasConstraintName("FK_Monitor_Clinicas");
        //});

        modelBuilder.Entity<MotivoConsultum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MotivoCo__3214EC0743F57EBD");

            entity.Property(e => e.Name).HasMaxLength(200);

            entity.HasOne(d => d.Clinica).WithMany(p => p.MotivoConsulta)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_MotivoConsulta_Clinicas");
        });

        modelBuilder.Entity<MotivoReagendum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MotivoRe__3214EC077EF455C8");

            entity.Property(e => e.FechaNueva).HasColumnType("datetime");
            entity.Property(e => e.FechaPautada).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.MotivoReagenda)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_MotivoReagenda_Clinicas");
        });

        modelBuilder.Entity<MovimientoDePaciente>(entity =>
        {
            entity.HasKey(e => e.MovimientoId).HasName("PK__Movimien__BF923C2CB953FC07");

            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdentificadorUbicacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MovimientoDateTime).HasColumnType("datetime");
            entity.Property(e => e.Notas)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Prefijo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoDeMovimiento)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.MovimientoDePacientes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_MovimientoDePacientes_Clinicas");

            entity.HasOne(d => d.Paciente).WithMany(p => p.MovimientoDePacientes)
                .HasForeignKey(d => d.PacienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Movimient__Pacie__4944D3CA");
        });

        modelBuilder.Entity<MovimientoInventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movimien__3214EC07690AB5DC");

            entity.ToTable("MovimientoInventario");

            entity.Property(e => e.Comentarios).HasColumnType("text");
            entity.Property(e => e.CostoTotalMovimiento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoUnitarioMovimiento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FechaMovimiento)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PrecioTotalMovimiento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioUnitarioMovimiento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ValorInventarioAlFinalMovimiento).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_MovimientoInventario_Clinicas");

            entity.HasOne(d => d.Inventario).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.InventarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_Inventario");

            entity.HasOne(d => d.StatusMovimiento).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.StatusMovimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_StatusMovimiento");

            entity.HasOne(d => d.TipoMovimiento).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.TipoMovimientoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_TipoMovimiento");

            entity.HasOne(d => d.UbicacionEmisor).WithMany(p => p.MovimientoInventarioUbicacionEmisors)
                .HasForeignKey(d => d.UbicacionEmisorId)
                .HasConstraintName("FK_MovimientoInventario_UbicacionEmisor");

            entity.HasOne(d => d.UbicacionReceptor).WithMany(p => p.MovimientoInventarioUbicacionReceptors)
                .HasForeignKey(d => d.UbicacionReceptorId)
                .HasConstraintName("FK_MovimientoInventario_UbicacionReceptor");

            entity.HasOne(d => d.UnidadMedida).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.UnidadMedidaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_UnidadesMedidas");
        });

        modelBuilder.Entity<NrComprobanteISRL>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__NrCompro__3213E83FAE8391EC");

            entity.ToTable("NrComprobanteISRL");

            entity.Property(e => e.Nrocomprobante)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.NrComprobanteISRLs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK__NrComprob__Clini__52CE3E04");
        });

        modelBuilder.Entity<NrComprobanteIVA>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__NrCompro__3213E83FB4B873AB");

            entity.ToTable("NrComprobanteIVA");

            entity.Property(e => e.Nrocomprobante)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.NrComprobanteIVAs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK__NrComprob__Clini__53C2623D");
        });

        modelBuilder.Entity<NroCaso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NroCaso__3214EC072DB3A69E");

            entity.ToTable("NroCaso");
        });

        modelBuilder.Entity<NroControl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NroContr__3214EC079B1B7A80");

            entity.ToTable("NroControl");

            entity.Property(e => e.NroControl1)
                .HasMaxLength(50)
                .HasColumnName("NroControl");
        });

        modelBuilder.Entity<NroControlEstudio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NroContr__3214EC07E4DED623");

            entity.HasOne(d => d.Clinica).WithMany(p => p.NroControlEstudios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_NroControlEstudios_Clinicas");
        });

        modelBuilder.Entity<NroControlNotaCredito>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NroContr__3214EC079E22CABF");

            entity.ToTable("NroControlNotaCredito");

            entity.HasOne(d => d.Clinica).WithMany(p => p.NroControlNotaCreditos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_NroControlNotaCredito_Clinicas");
        });

        modelBuilder.Entity<NroControlServicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NroContr__3214EC07C9B6F7EB");

            entity.HasOne(d => d.Clinica).WithMany(p => p.NroControlServicios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_NroControlServicios_Clinicas");
        });

        modelBuilder.Entity<NroFactura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NroFactu__3214EC076793BA38");

            entity.ToTable("NroFactura");

            entity.HasOne(d => d.Clinica).WithMany(p => p.NroFacturas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_NroFactura_Clinicas");
        });

        modelBuilder.Entity<NroNotaC>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NroNotaC__3214EC073FE7573A");

            entity.ToTable("NroNotaC");

            entity.Property(e => e.NroNotaCredito).HasMaxLength(50);
        });

        modelBuilder.Entity<NroNotaD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NroNotaD__3214EC07573ADA6A");

            entity.ToTable("NroNotaD");

            entity.Property(e => e.NroNotaDebito).HasMaxLength(50);
        });

        modelBuilder.Entity<Odontograma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Odontogr__3214EC075E32F177");

            entity.ToTable("Odontograma");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.Odontogramas)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK__Odontogra__Clini__5887175A");

            entity.HasOne(d => d.Servicios).WithMany(p => p.Odontogramas)
                .HasForeignKey(d => d.ServiciosId)
                .HasConstraintName("FK__Odontogra__Servi__597B3B93");
        });

        modelBuilder.Entity<Operacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Operacio__3214EC07007D8964");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Operaciones)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Operaciones_Clinicas");

            entity.HasOne(d => d.idModulosNavigation).WithMany(p => p.Operaciones)
                .HasForeignKey(d => d.idModulos)
                .HasConstraintName("FK__Operacion__idMod__5A6F5FCC");
        });

        modelBuilder.Entity<OrdenCompra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrdenCom__3214EC073E94359E");

            entity.ToTable("OrdenCompra");

            entity.HasIndex(e => e.Codigo, "UQ__OrdenCom__06370DAC3FFF29E4").IsUnique();

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Contacto).HasMaxLength(255);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_OrdenCompra_Clinicas");

            entity.HasOne(d => d.Moneda).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => d.MonedaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_Moneda");

            entity.HasOne(d => d.Provider).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => d.ProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompra_Proveedores");

            entity.HasOne(d => d.StatusOrdenCompra).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => d.StatusOrdenCompraId)
                .HasConstraintName("FK_OrdenCompra_StatusOrdenCompra");
        });

        modelBuilder.Entity<OrdenCompraDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrdenCom__3214EC07455FA343");

            entity.ToTable("OrdenCompraDetalle");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CodigoProducto).HasMaxLength(50);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ImporteNeto).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NombreProducto).HasMaxLength(255);
            entity.Property(e => e.PctDescuento).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.OrdenCompraDetalles)
                .HasForeignKey(d => d.ClinicasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompraDetalle_Clinicas");

            entity.HasOne(d => d.Inventario).WithMany(p => p.OrdenCompraDetalles)
                .HasForeignKey(d => d.InventarioId)
                .HasConstraintName("FK_OrdenCompraDetalle_Inventario");

            entity.HasOne(d => d.OrdenCompra).WithMany(p => p.OrdenCompraDetalles)
                .HasForeignKey(d => d.OrdenCompraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompraDetalle_OrdenCompra");

            entity.HasOne(d => d.Producto).WithMany(p => p.OrdenCompraDetalles)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompraDetalle_Productos");

            entity.HasOne(d => d.UnidadesMedidas).WithMany(p => p.OrdenCompraDetalles)
                .HasForeignKey(d => d.UnidadesMedidasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdenCompraDetalle_UnidadesMedidas");
        });

        modelBuilder.Entity<OrdenDeServicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrdenDeS__3214EC07365F60C5");

            entity.ToTable("OrdenDeServicio");

            entity.Property(e => e.Factura).HasMaxLength(100);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFactura).HasColumnType("datetime");
            entity.Property(e => e.TasaDeCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalBs).HasColumnType("decimal(28, 2)");
            entity.Property(e => e.TotalDivisas).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.idNroCaso).HasMaxLength(100);
            entity.Property(e => e.idOrdenServicio).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.OrdenDeServicios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_OrdenDeServicio_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.OrdenDeServicios)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__OrdenDeSe__idCed__15A53433");

            entity.HasOne(d => d.idConfirmacionEntregaNavigation).WithMany(p => p.OrdenDeServicioidConfirmacionEntregaNavigations)
                .HasForeignKey(d => d.idConfirmacionEntrega)
                .HasConstraintName("FK__OrdenDeSe__idCon__7E8CC4B1");

            entity.HasOne(d => d.idEnviadaNavigation).WithMany(p => p.OrdenDeServicioidEnviadaNavigations)
                .HasForeignKey(d => d.idEnviada)
                .HasConstraintName("FK__OrdenDeSe__idEnv__6C6E1476");

            entity.HasOne(d => d.idProveedorNavigation).WithMany(p => p.OrdenDeServicios)
                .HasForeignKey(d => d.idProveedor)
                .HasConstraintName("FK__OrdenDeSe__idPro__178D7CA5");

            entity.HasOne(d => d.idStatusOrdenNavigation).WithMany(p => p.OrdenDeServicios)
                .HasForeignKey(d => d.idStatusOrden)
                .HasConstraintName("FK__OrdenDeSe__idSta__1699586C");

            entity.HasOne(d => d.idUsuarioNavigation).WithMany(p => p.OrdenDeServicios)
                .HasForeignKey(d => d.idUsuario)
                .HasConstraintName("FK__OrdenDeSe__idUsu__1881A0DE");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paciente__3214EC0769FE5A51");

            entity.Property(e => e.Cedula).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DelegadoConsularResp).HasMaxLength(100);
            entity.Property(e => e.DireccionHabitacion).HasMaxLength(100);
            entity.Property(e => e.DireccionTrabajo).HasMaxLength(100);
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GrupoSanguineo).HasMaxLength(10);
            entity.Property(e => e.LugarNacimiento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NroHistoria).HasMaxLength(50);
            entity.Property(e => e.Ocupacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Parentesco)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrefijoCaso)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("-")
                .IsFixedLength();
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PrimerNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Responsable)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SegundoNombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoAcompañante).HasMaxLength(100);
            entity.Property(e => e.TelefonoCelular).HasMaxLength(100);
            entity.Property(e => e.TelefonoFamiliar).HasMaxLength(100);
            entity.Property(e => e.TelefonoHabitacion).HasMaxLength(100);
            entity.Property(e => e.TelefonoResponsable).HasMaxLength(100);
            entity.Property(e => e.TelefonoTrabajo).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Pacientes_Clinicas");

            entity.HasOne(d => d.idEstadoCivilNavigation).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.idEstadoCivil)
                .HasConstraintName("FK__Pacientes__idEst__770B9E7A");

            entity.HasOne(d => d.idGeneroNavigation).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.idGenero)
                .HasConstraintName("FK__Pacientes__idGen__78F3E6EC");

            entity.HasOne(d => d.idMenorDeEdadNavigation).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.idMenorDeEdad)
                .HasConstraintName("FK__Pacientes__idMen__7ADC2F5E");

            entity.HasOne(d => d.idReligionNavigation).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.idReligion)
                .HasConstraintName("FK__Pacientes__idRel__7CC477D0");
        });

        modelBuilder.Entity<PacienteEnEspera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paciente__3214EC079178D334");

            entity.ToTable("PacienteEnEspera");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateIngreso).HasColumnType("datetime");
            entity.Property(e => e.DateSalida).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.PacienteEnEsperas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_PacienteEnEspera_Clinicas");

            entity.HasOne(d => d.idPacienteNavigation).WithMany(p => p.PacienteEnEsperas)
                .HasForeignKey(d => d.idPaciente)
                .HasConstraintName("FK__PacienteE__idPac__6C8E1007");
        });

        modelBuilder.Entity<PacienteOncologico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paciente__3214EC07B58C53C7");

            entity.Property(e => e.Especificar).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.PacienteOncologicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_PacientesOncologicos_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.PacienteOncologicos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__PacienteO__idCed__6F6A7CB2");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.PacienteOncologicos)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__PacienteO__idMed__5224328E");

            entity.HasOne(d => d.idPacienteOncologicoNavigation).WithMany(p => p.PacienteOncologicoidPacienteOncologicoNavigations)
                .HasForeignKey(d => d.idPacienteOncologico)
                .HasConstraintName("FK__PacienteO__idPac__7246E95D");

            entity.HasOne(d => d.idRecibeQuimioNavigation).WithMany(p => p.PacienteOncologicoidRecibeQuimioNavigations)
                .HasForeignKey(d => d.idRecibeQuimio)
                .HasConstraintName("FK__PacienteO__idRec__742F31CF");
        });

        modelBuilder.Entity<PagoClasificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PagoClas__3214EC0763D891DF");

            entity.ToTable("PagoClasificacion");

            entity.Property(e => e.Tipo).HasMaxLength(50);
        });

        modelBuilder.Entity<Paraclinico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paraclin__3214EC07D29B0A9F");

            entity.Property(e => e.idNroCaso).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Paraclinicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ParaClinicos_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.Paraclinicos)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Paraclini__idCed__009508B4");

            entity.HasOne(d => d.idExamenesParaclinicosNavigation).WithMany(p => p.Paraclinicos)
                .HasForeignKey(d => d.idExamenesParaclinicos)
                .HasConstraintName("FK__Paraclini__idExa__01892CED");
        });

        modelBuilder.Entity<Parentesco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Parentes__3214EC0732E02C5B");

            entity.Property(e => e.Parentesco1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Parentesco");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Parentescos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Parentescos_Clinicas");
        });

        modelBuilder.Entity<Pasillo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pasillos__3214EC076DB153BE");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombrePasillo)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Almacen).WithMany(p => p.Pasillos)
                .HasForeignKey(d => d.AlmacenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pasillos_Almacenes");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Pasillos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Pasillos_Clinicas");
        });

        modelBuilder.Entity<PerfilesCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PerfilesClientes_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<PerfilesProveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PerfilesProveedores_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
        });

        modelBuilder.Entity<PeriodosFiscale>(entity =>
        {
            entity.HasIndex(e => new { e.Anio, e.Mes, e.ClinicasId }, "UQ_PeriodosFiscales_AnioMesClinica").IsUnique();

            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.CreadoPor).HasMaxLength(50);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.ModificadoPor).HasMaxLength(50);

            entity.HasOne(d => d.Clinicas).WithMany(p => p.PeriodosFiscales)
                .HasForeignKey(d => d.ClinicasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clinicas_PeriodosFiscales");
        });

        modelBuilder.Entity<Piso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pisos__3214EC0741EB28FF");

            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Pisos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK__Pisos__ClinicaId__75586032");
        });

        modelBuilder.Entity<PlanContable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlanCont__3214EC078D616337");

            entity.ToTable("PlanContable");

            entity.HasIndex(e => e.CodigoPlan, "UQ__PlanCont__BE470721BC00AE65").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoPlan)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnType("datetime");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.PlanContables)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK__PlanConta__Clini__0A1E72EE");

            entity.HasOne(d => d.UsuarioCreador).WithMany(p => p.PlanContableUsuarioCreadors)
                .HasForeignKey(d => d.UsuarioCreadorId)
                .HasConstraintName("FK__PlanConta__Usuar__0B129727");

            entity.HasOne(d => d.UsuarioModificador).WithMany(p => p.PlanContableUsuarioModificadors)
                .HasForeignKey(d => d.UsuarioModificadorId)
                .HasConstraintName("FK__PlanConta__Usuar__0C06BB60");
        });

        modelBuilder.Entity<PlanContableCuenta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PlanCont__3214EC070AC1DDFA");

            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Modificado).HasColumnType("datetime");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.PlanContableCuenta)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK__PlanConta__Clini__0CFADF99");

            entity.HasOne(d => d.CuentasContable).WithMany(p => p.PlanContableCuenta)
                .HasForeignKey(d => d.CuentasContableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PlanConta__Cuent__0DEF03D2");

            entity.HasOne(d => d.PlanContable).WithMany(p => p.PlanContableCuenta)
                .HasForeignKey(d => d.PlanContableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PlanConta__PlanC__0EE3280B");

            entity.HasOne(d => d.UsuarioCreador).WithMany(p => p.PlanContableCuentaUsuarioCreadors)
                .HasForeignKey(d => d.UsuarioCreadorId)
                .HasConstraintName("FK__PlanConta__Usuar__0FD74C44");

            entity.HasOne(d => d.UsuarioModificador).WithMany(p => p.PlanContableCuentaUsuarioModificadors)
                .HasForeignKey(d => d.UsuarioModificadorId)
                .HasConstraintName("FK__PlanConta__Usuar__10CB707D");
        });

        modelBuilder.Entity<PlantillasMensaje>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Plantill__3214EC07D6868D0E");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.PlantillasMensajes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_PlantillasMensajes_Clinicas");
        });

        modelBuilder.Entity<Poliza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Polizas__3214EC07A86255A6");

            entity.Property(e => e.CedulaPaciente)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Cobertura)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CodigoVerCaso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoVerSeguro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.NombrePoliza)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Cliente).WithMany(p => p.Polizas)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_Poliza_Clientes");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Polizas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Poliza_Clinicas");

            entity.HasOne(d => d.SeguroPacientes).WithMany(p => p.Polizas)
                .HasForeignKey(d => d.SeguroPacientesId)
                .HasConstraintName("FK_Poliza_SegurosPacientes");

            entity.HasOne(d => d.Servicio).WithMany(p => p.Polizas)
                .HasForeignKey(d => d.ServicioId)
                .HasConstraintName("FK_Poliza_Servicios");
        });

        modelBuilder.Entity<PrefijosCaso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prefijos__3214EC07BFBD4524");

            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Prefijo).HasMaxLength(10);

            entity.HasOne(d => d.Clinica).WithMany(p => p.PrefijosCasos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_PrefijosCasos_Clinicas");
        });

        modelBuilder.Entity<Presupuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Presupue__3214EC0749B33856");

            entity.ToTable("Presupuesto");

            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Deducible).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaAprobado).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SubTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.ClinicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presupuesto_Clinicas");

            entity.HasOne(d => d.Polizas).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.PolizasId)
                .HasConstraintName("FK_Presupuesto_Polizas");

            entity.HasOne(d => d.StatusPresupuesto).WithMany(p => p.Presupuestos)
                .HasForeignKey(d => d.StatusPresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presupuesto_StatusPresupuesto");
        });

        modelBuilder.Entity<PresupuestoHonorario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Presupue__3214EC071D03DB62");

            entity.ToTable("PresupuestoHonorario");

            entity.HasOne(d => d.Clinica).WithMany(p => p.PresupuestoHonorarios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_PresupuestoHonorario_Clinica");

            entity.HasOne(d => d.Honorario).WithMany(p => p.PresupuestoHonorarios)
                .HasForeignKey(d => d.HonorarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoHonorario_Honorario");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.PresupuestoHonorarios)
                .HasForeignKey(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoHonorario_Presupuesto");
        });

        modelBuilder.Entity<PresupuestoProducto>(entity =>
        {
            entity.ToTable("PresupuestoProducto");

            entity.HasIndex(e => new { e.PresupuestoId, e.ProductoId }, "UQ_PresupuestoProducto_PresupuestoId_ProductoId").IsUnique();

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.PresupuestoProductos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_PresupuestoProducto_Clinicas");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.PresupuestoProductos)
                .HasForeignKey(d => d.PresupuestoId)
                .HasConstraintName("FK_PresupuestoProducto_Presupuesto");

            entity.HasOne(d => d.Producto).WithMany(p => p.PresupuestoProductos)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_PresupuestoProducto_Producto");
        });

        modelBuilder.Entity<PresupuestoServicioClinico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Presupue__3214EC07DC942A22");

            entity.ToTable("PresupuestoServicioClinico");

            entity.HasOne(d => d.Clinica).WithMany(p => p.PresupuestoServicioClinicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_PresupuestoServicioClinico_Clinica");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.PresupuestoServicioClinicos)
                .HasForeignKey(d => d.PresupuestoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoServicioClinico_Presupuesto");

            entity.HasOne(d => d.ServicioClinico).WithMany(p => p.PresupuestoServicioClinicos)
                .HasForeignKey(d => d.ServicioClinicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoServicioClinico_ServicioClinico");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC07646355E5");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CostoUnitario).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Imagen)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_Categoria");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Productos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Productos_Clinicas");

            entity.HasOne(d => d.GrupoArticulo).WithMany(p => p.Productos)
                .HasForeignKey(d => d.GrupoArticuloId)
                .HasConstraintName("FK_Productos_GrupoArticulo");

            entity.HasOne(d => d.MetodoCosteo).WithMany(p => p.Productos)
                .HasForeignKey(d => d.MetodoCosteoId)
                .HasConstraintName("FK_Productos_MetodoCosteo");

            entity.HasOne(d => d.SubCategoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.SubCategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Productos_SubCategoria");

            entity.HasOne(d => d.UnidadMedidaAlmacenamiento).WithMany(p => p.ProductoUnidadMedidaAlmacenamientos)
                .HasForeignKey(d => d.UnidadMedidaAlmacenamientoId)
                .HasConstraintName("FK_Productos_UnidadMedidaAlmacenamiento");

            entity.HasOne(d => d.UnidadMedidaCompra).WithMany(p => p.ProductoUnidadMedidaCompras)
                .HasForeignKey(d => d.UnidadMedidaCompraId)
                .HasConstraintName("FK_Productos_UnidadMedidaCompra");

            entity.HasOne(d => d.UnidadMedidaDespacho).WithMany(p => p.ProductoUnidadMedidaDespachos)
                .HasForeignKey(d => d.UnidadMedidaDespachoId)
                .HasConstraintName("FK_Productos_UnidadMedidaDespacho");
        });

        modelBuilder.Entity<ProductoBaremo>(entity =>
        {
            entity.ToTable("ProductoBaremo");

            entity.HasIndex(e => new { e.ProductoId, e.BaremoId }, "UQ_ProductoBaremo_ProductoId_BaremoId").IsUnique();

            entity.HasOne(d => d.Baremo).WithMany(p => p.ProductoBaremos)
                .HasForeignKey(d => d.BaremoId)
                .HasConstraintName("FK_ProductoBaremo_Baremo");

            entity.HasOne(d => d.Clinica).WithMany(p => p.ProductoBaremos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ProductoBaremo_Clinicas");

            entity.HasOne(d => d.Producto).WithMany(p => p.ProductoBaremos)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_ProductoBaremo_Producto");
        });

        modelBuilder.Entity<ProgramacionQuirurgica>(entity =>
        {
            entity.HasKey(e => e.IdProgramacion).HasName("PK_dbo.ProgramacionQuirurgica");

            entity.ToTable("ProgramacionQuirurgica");

            entity.Property(e => e.EstadoProgramacion).HasMaxLength(50);
            entity.Property(e => e.FechaAdmision).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraFin).HasColumnType("datetime");
            entity.Property(e => e.FechaHoraInicio).HasColumnType("datetime");
            entity.Property(e => e.IdEstadoCirugia).HasDefaultValue(1);
            entity.Property(e => e.MedicoAsignado).HasMaxLength(255);
            entity.Property(e => e.Motivo).HasMaxLength(500);
            entity.Property(e => e.NumeroCaso).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ProgramacionQuirurgicas)
                .HasForeignKey(d => d.ClinicaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ProgramacionQuirurgica_dbo.Clinicas_ClinicaId");

            entity.HasOne(d => d.IdCamillaNavigation).WithMany(p => p.ProgramacionQuirurgicas)
                .HasForeignKey(d => d.IdCamilla)
                .HasConstraintName("FK_dbo.ProgramacionQuirurgica_dbo.Camas_IdCamilla");

            entity.HasOne(d => d.IdEstadoCirugiaNavigation).WithMany(p => p.ProgramacionQuirurgicas)
                .HasForeignKey(d => d.IdEstadoCirugia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramacionQuirurgica_EstadoCirugia");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.ProgramacionQuirurgicas)
                .HasForeignKey(d => d.IdPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ProgramacionQuirurgica_dbo.Pacientes_IdPaciente");

            entity.HasOne(d => d.IdQuirofanoNavigation).WithMany(p => p.ProgramacionQuirurgicas)
                .HasForeignKey(d => d.IdQuirofano)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.ProgramacionQuirurgica_dbo.Habitaciones_IdQuirofano");
        });

        modelBuilder.Entity<PropuestaPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Propuest__3214EC07C2BCD6E1");

            entity.ToTable("PropuestaPago");

            entity.Property(e => e.CodigoFactura).HasMaxLength(50);
            entity.Property(e => e.NroFactura).HasMaxLength(50);
            entity.Property(e => e.NroPropuesta).HasMaxLength(50);
            entity.Property(e => e.TotalFactura).HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.PropuestaPagos)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_PropuestaPago_Clinicas");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proveedo__3214EC07BFC4368B");

            entity.Property(e => e.Cadena).HasMaxLength(50);
            entity.Property(e => e.CorreoElectronico).HasMaxLength(100);
            entity.Property(e => e.CuentaBancaria).HasMaxLength(100);
            entity.Property(e => e.Direccion).HasMaxLength(100);
            entity.Property(e => e.DireccionWeb).HasMaxLength(100);
            entity.Property(e => e.Especialidad).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(100);
            entity.Property(e => e.LimiteCredito).HasMaxLength(100);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasMaxLength(100);
            entity.Property(e => e.PrecioCaso).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rif).HasMaxLength(50);
            entity.Property(e => e.SubEspecialidad).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(100);
            entity.Property(e => e.TelefonoMovil).HasMaxLength(100);
            entity.Property(e => e.TipoConvenio).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Proveedores_Clinicas");

            entity.HasOne(d => d.idCategoriaItemsNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.idCategoriaItems)
                .HasConstraintName("FK__Proveedor__idCat__3414ACBA");

            entity.HasOne(d => d.idCiudadNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.idCiudad)
                .HasConstraintName("FK__Proveedor__idCiu__35FCF52C");

            entity.HasOne(d => d.idClasificacionProveedorNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.idClasificacionProveedor)
                .HasConstraintName("FK__Proveedor__idCla__37E53D9E");

            entity.HasOne(d => d.idCondicionesConvenioNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.idCondicionesConvenio)
                .HasConstraintName("FK__Proveedor__idCon__39CD8610");

            entity.HasOne(d => d.idDiaPagoNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.idDiaPago)
                .HasConstraintName("FK__Proveedor__idDia__3BB5CE82");

            entity.HasOne(d => d.idEstadoNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.idEstado)
                .HasConstraintName("FK__Proveedor__idEst__3D9E16F4");

            entity.HasOne(d => d.idFormaPagoNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.idFormaPago)
                .HasConstraintName("FK__Proveedor__idFor__3F865F66");

            entity.HasOne(d => d.idMonedaNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.idMoneda)
                .HasConstraintName("FK__Proveedor__idMon__416EA7D8");

            entity.HasOne(d => d.idTipoPersonaNavigation).WithMany(p => p.Proveedores)
                .HasForeignKey(d => d.idTipoPersona)
                .HasConstraintName("FK__Proveedor__idTip__4356F04A");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Recipe__3214EC071F95C423");

            entity.ToTable("Recipe");

            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Indicaciones).HasMaxLength(500);
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.PrefijoDepartamento).HasMaxLength(10);
            entity.Property(e => e.idNroCaso).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Recipe_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Recipe__idCedula__4BEC364B");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__Recipe__idMedico__7F2BE32F");
        });

        modelBuilder.Entity<RegistroFactua>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.IFGT).HasMaxLength(50);
            entity.Property(e => e.IVA).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany()
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_RegistroFactuas_Clinicas");

            entity.HasOne(d => d.idCitasMedicasNavigation).WithMany()
                .HasForeignKey(d => d.idCitasMedicas)
                .HasConstraintName("FK__RegistroF__idCit__420DC656");

            entity.HasOne(d => d.idNroFacturaNavigation).WithMany()
                .HasForeignKey(d => d.idNroFactura)
                .HasConstraintName("FK__RegistroF__idNro__50B0EB68");

            entity.HasOne(d => d.idPacienteNavigation).WithMany()
                .HasForeignKey(d => d.idPaciente)
                .HasConstraintName("FK__RegistroF__idPac__529933DA");
        });

        modelBuilder.Entity<RegistroPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Registro__3214EC07AB040993");

            entity.ToTable("RegistroPago");

            entity.Property(e => e.Codigo).HasMaxLength(100);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.MontoBs).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.MontoDivisas).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notas).HasMaxLength(200);
            entity.Property(e => e.Referencia).HasMaxLength(100);

            entity.HasOne(d => d.Clientes).WithMany(p => p.RegistroPagos)
                .HasForeignKey(d => d.ClientesId)
                .HasConstraintName("FK_RegistroPago_Clientes");

            entity.HasOne(d => d.Clinica).WithMany(p => p.RegistroPagos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_RegistroPago_Clinicas");

            entity.HasOne(d => d.Presupuesto).WithMany(p => p.RegistroPagos)
                .HasForeignKey(d => d.PresupuestoId)
                .HasConstraintName("FK_RegistroPago_Presupuesto");

            entity.HasOne(d => d.TipoPago).WithMany(p => p.RegistroPagos)
                .HasForeignKey(d => d.TipoPagoId)
                .HasConstraintName("FK_RegistroPago_TipoPago");

            entity.HasOne(d => d.UserRegisterNavigation).WithMany(p => p.RegistroPagos)
                .HasForeignKey(d => d.UserRegister)
                .HasConstraintName("FK__RegistroP__UserR__31D75E8D");

            entity.HasOne(d => d.idFormaPagoNavigation).WithMany(p => p.RegistroPagos)
                .HasForeignKey(d => d.idFormaPago)
                .HasConstraintName("FK__RegistroP__idFor__30E33A54");
        });

        modelBuilder.Entity<ReglasConversionUnidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReglasCo__3214EC07D33FC114");

            entity.HasIndex(e => new { e.UnidadMedidaOrigenId, e.UnidadMedidaDestinoId }, "UQ_ConversionesUnidades_UnidadMedidaOrigenId_UnidadMedidaDestinoId").IsUnique();

            entity.Property(e => e.Denominador).HasColumnType("decimal(18, 10)");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Numerador).HasColumnType("decimal(18, 10)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.ReglasConversionUnidades)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ReglasConversionUnidades_Clinicas");

            entity.HasOne(d => d.Producto).WithMany(p => p.ReglasConversionUnidades)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_ConversionesUnidades_Productos");

            entity.HasOne(d => d.UnidadMedidaDestino).WithMany(p => p.ReglasConversionUnidadeUnidadMedidaDestinos)
                .HasForeignKey(d => d.UnidadMedidaDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConversionesUnidades_UnidadMedidaDestinoId");

            entity.HasOne(d => d.UnidadMedidaOrigen).WithMany(p => p.ReglasConversionUnidadeUnidadMedidaOrigens)
                .HasForeignKey(d => d.UnidadMedidaOrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConversionesUnidades_UnidadMedidaOrigenId");
        });

        modelBuilder.Entity<Religion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Religion__3214EC074AFFD71D");

            entity.ToTable("Religion");

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Religions)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Religion_Clinicas");
        });

        modelBuilder.Entity<ResRapidum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ResRapid__3214EC077B49D20C");

            entity.Property(e => e.Respuesta)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ResRapida)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ResRapida_Clinicas");
        });

        modelBuilder.Entity<ReservaEmergencium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReservaE__3214EC07989BF8EA");

            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaAgendada)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TipoEmergencia).HasMaxLength(50);
            entity.Property(e => e.TipoTerapia).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ReservaEmergencia)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ReservaEmergencia_Clinicas");

            entity.HasOne(d => d.Pacientes).WithMany(p => p.ReservaEmergencia)
                .HasForeignKey(d => d.PacientesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservaEmergencia_Pacientes");

            entity.HasOne(d => d.ServicioDeEspacio).WithMany(p => p.ReservaEmergencia)
                .HasForeignKey(d => d.ServicioDeEspacioId)
                .HasConstraintName("FK_ReservaEmergencia_ServicioDeEspacio");

            entity.HasOne(d => d.Servicios).WithMany(p => p.ReservaEmergencia)
                .HasForeignKey(d => d.ServiciosId)
                .HasConstraintName("FK_ReservaEmergencia_Servicios");
        });

        modelBuilder.Entity<ReservaHospitalizacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ReservaH__3214EC076070EA6A");

            entity.ToTable("ReservaHospitalizacion");

            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaAgendada).HasColumnType("datetime");
            entity.Property(e => e.Motivo).HasMaxLength(500);
            entity.Property(e => e.TipoHospitalizacion).HasMaxLength(50);
            entity.Property(e => e.TipoTerapia).HasMaxLength(50);

            entity.HasOne(d => d.Cama).WithMany(p => p.ReservaHospitalizacions)
                .HasForeignKey(d => d.CamaId)
                .HasConstraintName("FK_ReservaHospitalizacion_Camas");

            entity.HasOne(d => d.Clinica).WithMany(p => p.ReservaHospitalizacions)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ReservaHospitalizacion_Clinicas");

            entity.HasOne(d => d.ServicioEspacio).WithMany(p => p.ReservaHospitalizacions)
                .HasForeignKey(d => d.ServicioEspacioId)
                .HasConstraintName("FK_ReservaHospitalizacion_ServicioDeEspacio");

            entity.HasOne(d => d.Servicio).WithMany(p => p.ReservaHospitalizacions)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservaHospitalizacion_Servicios");
        });

        modelBuilder.Entity<RetencionServicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Retencio__3214EC075987DB7B");

            entity.Property(e => e.CodigoRetencion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MontoRetencion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorRetencion).HasColumnType("decimal(5, 4)");
        });

        modelBuilder.Entity<Retencione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Retencio__3214EC07690AA05C");

            entity.Property(e => e.Codigo).HasMaxLength(20);
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Maximo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Minimo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Valor).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<RetencionesFactura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Retencio__3214EC074463955B");

            entity.Property(e => e.CodigoFactura)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoRetencion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NroComprobante).HasMaxLength(100);
            entity.Property(e => e.ValorRetencion).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.RetencionesFacturas)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK_RetencionesFacturas_Clinicas");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.RetencionesFacturas)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("FK_RetencionesFacturas_Facturas");

            entity.HasOne(d => d.IdRetencionNavigation).WithMany(p => p.RetencionesFacturas)
                .HasForeignKey(d => d.IdRetencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RetencionesFacturas_Retenciones");

            entity.HasOne(d => d.IdTipoRetencionNavigation).WithMany(p => p.RetencionesFacturas)
                .HasForeignKey(d => d.IdTipoRetencion)
                .HasConstraintName("FK_RetencionesFacturas_TipoRetencion");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol__3214EC0737602E8E");

            entity.ToTable("Rol");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Rols)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Rol_Clinicas");

            entity.HasMany(d => d.Modulos).WithMany(p => p.Rols)
                .UsingEntity<Dictionary<string, object>>(
                    "Rol_Modulo",
                    r => r.HasOne<ModulosClinica>().WithMany()
                        .HasForeignKey("ModuloId")
                        .HasConstraintName("FK_Rol_Modulos_ModulosClinicas"),
                    l => l.HasOne<Rol>().WithMany()
                        .HasForeignKey("RolId")
                        .HasConstraintName("FK__Rol_Modul__RolId__6D4D2A16"),
                    j =>
                    {
                        j.HasKey("RolId", "ModuloId").HasName("PK__Rol_Modu__1B4FE97F23E44545");
                        j.ToTable("Rol_Modulos");
                    });
        });

        modelBuilder.Entity<Rol_Operacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol_Oper__3214EC0785843B57");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Rol_Operaciones)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Rol_Operaciones_Clinicas");

            entity.HasOne(d => d.idOperacionesNavigation).WithMany(p => p.Rol_Operaciones)
                .HasForeignKey(d => d.idOperaciones)
                .HasConstraintName("FK__Rol_Opera__idOpe__6F357288");

            entity.HasOne(d => d.idRolNavigation).WithMany(p => p.Rol_Operaciones)
                .HasForeignKey(d => d.idRol)
                .HasConstraintName("FK__Rol_Opera__idRol__711DBAFA");
        });

        modelBuilder.Entity<SegmentosContable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SegmentosContables_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CodigoSegmento).IsUnicode(false);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.Nombre).IsUnicode(false);
        });

        modelBuilder.Entity<Seguro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Seguros__3214EC07A2E876D4");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Seguros)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Seguros_Clinicas");
        });

        modelBuilder.Entity<SeguroCasosEmergencium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SeguroCa__3214EC07BA3F4E08");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Deducible).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.MontoCobertura).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.SeguroCasosEmergencia)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_SeguroCasosEmergencia_Clinicas");

            entity.HasOne(d => d.idPacienteNavigation).WithMany(p => p.SeguroCasosEmergencia)
                .HasForeignKey(d => d.idPaciente)
                .HasConstraintName("FK__SeguroCas__idPac__73FA27A5");

            entity.HasOne(d => d.idSeguroNavigation).WithMany(p => p.SeguroCasosEmergencia)
                .HasForeignKey(d => d.idSeguro)
                .HasConstraintName("FK__SeguroCas__idSeg__75E27017");
        });

        modelBuilder.Entity<SegurosAdmitido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SegurosA__3214EC07B7DF73DD");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.SegurosAdmitidos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_SegurosAdmitidos_Clinicas");
        });

        modelBuilder.Entity<SegurosPaciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SegurosP__3214EC07F70A03DC");

            entity.Property(e => e.Cedula).HasMaxLength(100);
            entity.Property(e => e.Empresa).HasMaxLength(100);
            entity.Property(e => e.ParentescoConPaciente).HasMaxLength(100);
            entity.Property(e => e.PrimerApellido).HasMaxLength(100);
            entity.Property(e => e.PrimerNombre).HasMaxLength(100);
            entity.Property(e => e.SegundoApellido).HasMaxLength(100);
            entity.Property(e => e.SegundoNombre).HasMaxLength(100);
            entity.Property(e => e.TelefonoCelular).HasMaxLength(100);
            entity.Property(e => e.TelefonoHabitacion).HasMaxLength(100);
            entity.Property(e => e.TelefonoTrabajo).HasMaxLength(100);

            entity.HasOne(d => d.Cliente).WithMany(p => p.SegurosPacientes)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("FK_SegurosPacientes_Clientes");

            entity.HasOne(d => d.Clinica).WithMany(p => p.SegurosPacientes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_SegurosPacientes_Clinicas");

            entity.HasOne(d => d.TipoCliente).WithMany(p => p.SegurosPacientes)
                .HasForeignKey(d => d.TipoClienteId)
                .HasConstraintName("FK_SegurosPacientes_TipoCliente");

            entity.HasOne(d => d.idPacientesNavigation).WithMany(p => p.SegurosPacientes)
                .HasForeignKey(d => d.idPacientes)
                .HasConstraintName("FK__SegurosPa__idPac__7AA72534");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC07B204454E");

            entity.Property(e => e.Autor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CodigoTratante)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.FechaAbono).HasColumnType("datetime");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaCorreoProveedor).HasColumnType("datetime");
            entity.Property(e => e.MontoAsegurado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PDFFactura).HasMaxLength(100);
            entity.Property(e => e.PorPagar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sintomas)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TasaCambio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAbonos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalBs).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCargos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalDivisas).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Servicios_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Servicios__idCed__12E8C319");

            entity.HasOne(d => d.idClienteNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.idCliente)
                .HasConstraintName("FK__Servicios__idCli__14D10B8B");

            entity.HasOne(d => d.idEstadoOrdenSeguroNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.idEstadoOrdenSeguro)
                .HasConstraintName("FK__Servicios__idEst__127EAEC5");

            entity.HasOne(d => d.idPrefijosCasosNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.idPrefijosCasos)
                .HasConstraintName("FK__Servicios__idPre__1466F737");

            entity.HasOne(d => d.idStatusCasoNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.idStatusCaso)
                .HasConstraintName("FK__Servicios__idSta__16B953FD");

            entity.HasOne(d => d.idStatusCitaNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.idStatusCita)
                .HasConstraintName("FK__Servicios__idSta__17AD7836");

            entity.HasOne(d => d.idStatusFacturacionNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.idStatusFacturacion)
                .HasConstraintName("FK__Servicios__idSta__15C52FC4");

            entity.HasOne(d => d.idTipoClienteNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.idTipoCliente)
                .HasConstraintName("FK__Servicios__idTip__13DCE752");
        });

        modelBuilder.Entity<ServicioClinico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC0796197837");

            entity.ToTable("ServicioClinico");

            entity.Property(e => e.Cantidad).HasDefaultValue(0);
            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NroCaso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.ServicioClinicos)
                .HasForeignKey(d => d.ClinicasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicioClinico_Clinicas");

            entity.HasOne(d => d.StatusUser).WithMany(p => p.ServicioClinicos)
                .HasForeignKey(d => d.StatusUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicioClinico_StatusUser");
        });

        modelBuilder.Entity<ServicioClinicoBaremo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC07527638F3");

            entity.ToTable("ServicioClinicoBaremo");

            entity.HasOne(d => d.Baremo).WithMany(p => p.ServicioClinicoBaremos)
                .HasForeignKey(d => d.BaremoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicioClinicoBaremo_Baremo");

            entity.HasOne(d => d.Clinica).WithMany(p => p.ServicioClinicoBaremos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ServicioClinicoBaremo_Clinicas");

            entity.HasOne(d => d.ServicioClinico).WithMany(p => p.ServicioClinicoBaremos)
                .HasForeignKey(d => d.ServicioClinicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicioClinicoBaremo_ServicioClinico");
        });

        modelBuilder.Entity<ServicioDeEspacio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC076EF8DC98");

            entity.ToTable("ServicioDeEspacio");

            entity.Property(e => e.Categoria)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrecioTotalPorDia).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PrecioTotalPorHora).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.ServicioDeEspacios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK__ServicioD__Clini__04308F6E");
        });

        modelBuilder.Entity<ServicioDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC07937234B4");

            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.MesServicio).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ServicioDetalles)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ServicioDetalles_Clinicas");

            entity.HasOne(d => d.idCategoriaItemsNavigation).WithMany(p => p.ServicioDetalles)
                .HasForeignKey(d => d.idCategoriaItems)
                .HasConstraintName("FK__ServicioD__idCat__1A89E4E1");

            entity.HasOne(d => d.idEspecialidadNavigation).WithMany(p => p.ServicioDetalles)
                .HasForeignKey(d => d.idEspecialidad)
                .HasConstraintName("FK__ServicioD__idEsp__1D66518C");

            entity.HasOne(d => d.idItemsNavigation).WithMany(p => p.ServicioDetalles)
                .HasForeignKey(d => d.idItems)
                .HasConstraintName("FK__ServicioD__idIte__1F4E99FE");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.ServicioDetalleidMedicoNavigations)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__ServicioD__idMed__1B7E091A");

            entity.HasOne(d => d.idMotivoConsultaNavigation).WithMany(p => p.ServicioDetalles)
                .HasForeignKey(d => d.idMotivoConsulta)
                .HasConstraintName("FK__ServicioD__idMot__1C722D53");

            entity.HasOne(d => d.idProveedorNavigation).WithMany(p => p.ServicioDetalles)
                .HasForeignKey(d => d.idProveedor)
                .HasConstraintName("FK__ServicioD__idPro__1E5A75C5");

            entity.HasOne(d => d.idProveedorInternoNavigation).WithMany(p => p.ServicioDetalleidProveedorInternoNavigations)
                .HasForeignKey(d => d.idProveedorInterno)
                .HasConstraintName("FK__ServicioD__idPro__0BD1B136");

            entity.HasOne(d => d.idStatusConsultaNavigation).WithMany(p => p.ServicioDetalles)
                .HasForeignKey(d => d.idStatusConsulta)
                .HasConstraintName("FK__ServicioD__idSta__0DB9F9A8");
        });

        modelBuilder.Entity<ServiciosConfigurable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC0742DFE658");

            entity.Property(e => e.Codigo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CodigoFacturacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PrefijoCaso_ID)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ServiciosConfigurables)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ServiciosConfigurables_Clinicas");

            entity.HasOne(d => d.Piso).WithMany(p => p.ServiciosConfigurables)
                .HasForeignKey(d => d.Piso_ID)
                .HasConstraintName("FK_ServiciosConfigurables_Pisos");
        });

        modelBuilder.Entity<ServiciosProveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC078DBF9ABF");

            entity.HasOne(d => d.Clinica).WithMany(p => p.ServiciosProveedores)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ServiciosProveedores_Clinicas");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ServiciosProveedores)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiciosProveedores_Proveedores");

            entity.HasOne(d => d.Servicio).WithMany(p => p.ServiciosProveedores)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServiciosProveedores_Servicios");
        });

        modelBuilder.Entity<Solicitud>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Solicitu__3214EC073BCA4D8C");

            entity.ToTable("Solicitud");

            entity.Property(e => e.CostoExamen).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.OrdenServicio).HasMaxLength(100);
            entity.Property(e => e.PreOrdenServicio).HasMaxLength(100);
            entity.Property(e => e.PrefijoDepartamento).HasMaxLength(10);
            entity.Property(e => e.idNroCaso).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Solicitud_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__Solicitud__idCed__1FD8A9E3");

            entity.HasOne(d => d.idExamenesNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.idExamenes)
                .HasConstraintName("FK__Solicitud__idExa__13F1F5EB");

            entity.HasOne(d => d.idGeneradaNavigation).WithMany(p => p.SolicitudidGeneradaNavigations)
                .HasForeignKey(d => d.idGenerada)
                .HasConstraintName("FK__Solicitud__idGen__22B5168E");

            entity.HasOne(d => d.idInterconsultaEnviadaNavigation).WithMany(p => p.SolicitudidInterconsultaEnviadaNavigations)
                .HasForeignKey(d => d.idInterconsultaEnviada)
                .HasConstraintName("FK__Solicitud__idInt__249D5F00");

            entity.HasOne(d => d.idMedicoInternoNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.idMedicoInterno)
                .HasConstraintName("FK__Solicitud__idMed__4924D839");

            entity.HasOne(d => d.idProveedorNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.idProveedor)
                .HasConstraintName("FK__Solicitud__idPro__2779CBAB");

            entity.HasOne(d => d.idTipoExamaenNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.idTipoExamaen)
                .HasConstraintName("FK__Solicitud__idTip__2962141D");

            entity.HasOne(d => d.idTipoInterconsultaNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.idTipoInterconsulta)
                .HasConstraintName("FK__Solicitud__idTip__2A563856");
        });

        modelBuilder.Entity<StatusCaso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusCa__3214EC07E6B7078A");

            entity.ToTable("StatusCaso");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.StatusCasos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_StatusCaso_Clinicas");
        });

        modelBuilder.Entity<StatusCitum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusCi__3214EC07F880FF9C");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.StatusCita)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_StatusCita_Clinicas");
        });

        modelBuilder.Entity<StatusConfirmacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusCo__3214EC07B2A56787");

            entity.ToTable("StatusConfirmacion");

            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.StatusConfirmacions)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_StatusConfirmacion_Clinicas");
        });

        modelBuilder.Entity<StatusFacturacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusFa__3214EC0786EB7DFE");

            entity.ToTable("StatusFacturacion");

            entity.Property(e => e.Estado).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.StatusFacturacions)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_StatusFacturacion_Clinicas");
        });

        modelBuilder.Entity<StatusMovimientoInventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusMo__3214EC073D9A1F2C");

            entity.ToTable("StatusMovimientoInventario");

            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.StatusMovimientoInventarios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_StatusMovimientoInventario_Clinicas");
        });

        modelBuilder.Entity<StatusOrden>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusOr__3214EC07024DE6DF");

            entity.ToTable("StatusOrden");

            entity.Property(e => e.Estado).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.StatusOrdens)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_StatusOrden_Clinicas");
        });

        modelBuilder.Entity<StatusOrdenCompra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusOr__3214EC07E5FBEF47");

            entity.ToTable("StatusOrdenCompra");

            entity.HasIndex(e => e.NombreStatus, "UQ__StatusOr__57C7628A5057DB71").IsUnique();

            entity.Property(e => e.NombreStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<StatusPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusPa__3214EC07D9E78471");

            entity.ToTable("StatusPago");

            entity.Property(e => e.Estado).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.StatusPagos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_StatusPago_Clinicas");
        });

        modelBuilder.Entity<StatusPresupuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusPr__3214EC0753441074");

            entity.ToTable("StatusPresupuesto");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.StatusPresupuestos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_StatusPresupuesto_Clinicas");
        });

        modelBuilder.Entity<StatusUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusUs__3214EC07E0D0A225");

            entity.ToTable("StatusUser");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.StatusUsers)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_StatusUser_Clinicas");
        });

        modelBuilder.Entity<SubCategorium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SubCateg__3214EC077E59C036");

            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreSubCategoria)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Categoria).WithMany(p => p.SubCategoria)
                .HasForeignKey(d => d.CategoriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubCategoria_Categoria");

            entity.HasOne(d => d.Clinica).WithMany(p => p.SubCategoria)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_SubCategoria_Clinicas");
        });

        modelBuilder.Entity<TasaCambio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TasaCamb__3214EC07DED0DF1A");

            entity.ToTable("TasaCambio");

            entity.Property(e => e.DateUpdate).HasColumnType("datetime");
            entity.Property(e => e.Tasa).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.TasaCambios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TasaCambio_Clinicas");
        });

        modelBuilder.Entity<TipoAlmacen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoAlma__3214EC077E4E0330");

            entity.ToTable("TipoAlmacen");

            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreTipoAlmacen)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoAlmacens)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoAlmacen_Clinicas");
        });

        modelBuilder.Entity<TipoBanco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoBanc__3214EC076076C277");

            entity.ToTable("TipoBanco");

            entity.Property(e => e.Tipo).HasMaxLength(20);
        });

        modelBuilder.Entity<TipoCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoClie__3214EC07184C18F5");

            entity.ToTable("TipoCliente");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoClientes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoCliente_Clinicas");
        });

        modelBuilder.Entity<TipoCuentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoCuen__3214EC071FD75D99");

            entity.HasIndex(e => e.CodigoTipo, "UQ__TipoCuen__368A84DAAE09D644").IsUnique();

            entity.Property(e => e.CodigoTipo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnType("datetime");

            entity.HasOne(d => d.Clinicas).WithMany(p => p.TipoCuenta)
                .HasForeignKey(d => d.ClinicasId)
                .HasConstraintName("FK__TipoCuent__Clini__3B80C458");

            entity.HasOne(d => d.UsuarioCreador).WithMany(p => p.TipoCuentumUsuarioCreadors)
                .HasForeignKey(d => d.UsuarioCreadorId)
                .HasConstraintName("FK__TipoCuent__Usuar__3C74E891");

            entity.HasOne(d => d.UsuarioModificador).WithMany(p => p.TipoCuentumUsuarioModificadors)
                .HasForeignKey(d => d.UsuarioModificadorId)
                .HasConstraintName("FK__TipoCuent__Usuar__3D690CCA");
        });

        modelBuilder.Entity<TipoDeSangre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoDeSa__3214EC073F3A81CA");

            entity.ToTable("TipoDeSangre");

            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoDeSangres)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoDeSangre_Clinicas");

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.TipoDeSangres)
                .HasForeignKey(d => d.idCedulaPaciente)
                .HasConstraintName("FK__TipoDeSan__idCed__44CA3770");

            entity.HasOne(d => d.idClasificacionSangreNavigation).WithMany(p => p.TipoDeSangres)
                .HasForeignKey(d => d.idClasificacionSangre)
                .HasConstraintName("FK__TipoDeSan__idCla__3F51553C");

            entity.HasOne(d => d.idFactorRHNavigation).WithMany(p => p.TipoDeSangres)
                .HasForeignKey(d => d.idFactorRH)
                .HasConstraintName("FK__TipoDeSan__idFac__41399DAE");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.TipoDeSangres)
                .HasForeignKey(d => d.idMedico)
                .HasConstraintName("FK__TipoDeSan__idMed__45BE5BA9");
        });

        modelBuilder.Entity<TipoDocumentacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoDocu__3214EC0734A39E37");

            entity.ToTable("TipoDocumentacion");

            entity.Property(e => e.Descripcion).HasMaxLength(20);
            entity.Property(e => e.Tipo).HasMaxLength(1);
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoDocu__3214EC0776185908");

            entity.ToTable("TipoDocumento");

            entity.Property(e => e.Tipo).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoEnfermedade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoEnfe__3214EC0719A9BCDD");

            entity.Property(e => e.Tipo).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoEnfermedades)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoEnfermedades_Clinicas");
        });

        modelBuilder.Entity<TipoEstudio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoEstu__3214EC0779B92DE9");

            entity.ToTable("TipoEstudio");

            entity.Property(e => e.Tipo).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoEstudios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoEstudio_Clinicas");
        });

        modelBuilder.Entity<TipoExaman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoExam__3214EC0777588D9C");

            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoExamen)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoExamen_Clinicas");
        });

        modelBuilder.Entity<TipoFactura>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__TipoFact__3213E83FD209240C");

            entity.ToTable("TipoFactura");

            entity.HasIndex(e => e.Tipo, "UQ__TipoFact__8E762CB491A3FD82").IsUnique();

            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoIVA>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoIVA__3214EC07706D9BD3");

            entity.ToTable("TipoIVA");

            entity.Property(e => e.Tipo).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoIVAs)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoIva_Clinicas");
        });

        modelBuilder.Entity<TipoInformeMedico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoInfo__3214EC07878C26FA");

            entity.ToTable("TipoInformeMedico");

            entity.HasIndex(e => e.Nombre, "UQ__TipoInfo__75E3EFCF55F7EC1D").IsUnique();

            entity.HasIndex(e => e.Nombre, "UQ__TipoInfo__75E3EFCFC95605BA").IsUnique();

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoInformeMedicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoInformeMedico_Clinicas");
        });

        modelBuilder.Entity<TipoInterconsultum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoInte__3214EC07DAE403B3");

            entity.Property(e => e.Tipo).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoInterconsulta)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoInterconsulta_Clinicas");
        });

        modelBuilder.Entity<TipoMovimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoMovi__3214EC0728D459FB");

            entity.ToTable("TipoMovimiento");

            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreTipoMovimiento)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoMovimientos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoMovimiento_Clinicas");
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoPago__3214EC07AF464D4F");

            entity.ToTable("TipoPago");

            entity.HasIndex(e => e.Nombre, "UQ__TipoPago__75E3EFCF5B697AF2").IsUnique();

            entity.HasIndex(e => e.Nombre, "UQ__TipoPago__75E3EFCFB1EED0BA").IsUnique();

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoPagos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoPago_Clinicas");
        });

        modelBuilder.Entity<TipoPersona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoPers__3214EC073C285341");

            entity.ToTable("TipoPersona");

            entity.Property(e => e.Tipo).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoPersonas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoPersona_Clinicas");
        });

        modelBuilder.Entity<TipoProyeccionesRayosX>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoProy__3214EC077C0033F7");

            entity.ToTable("TipoProyeccionesRayosX");

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoProyeccionesRayosXes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoProyeccionesRayosX_Clinicas");
        });

        modelBuilder.Entity<TipoRayosX>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoRayo__3214EC07B274AB64");

            entity.ToTable("TipoRayosX");

            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Precio).HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoRayosXes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoRayosX_Clinicas");
        });

        modelBuilder.Entity<TipoRetencion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoRete__3214EC07424E6D54");

            entity.ToTable("TipoRetencion");

            entity.Property(e => e.Tipo).HasMaxLength(50);
        });

        modelBuilder.Entity<TipoUnidadMedidum>(entity =>
        {
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreTipo).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TipoUnidadMedida)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TipoUnidadMedida_Clinicas");
        });

        modelBuilder.Entity<TiposExamenesInforme>(entity =>
        {
            entity.ToTable("TiposExamenesInforme");

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Clinica).WithMany(p => p.TiposExamenesInformes)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_TiposExamenesInforme_Clinicas");
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Turnos_Clinicas");
        });

        modelBuilder.Entity<Ubicacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ubicacio__3214EC070FDA1741");

            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreUbicacion)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Almacen).WithMany(p => p.Ubicaciones)
                .HasForeignKey(d => d.AlmacenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ubicaciones_Almacenes");

            entity.HasOne(d => d.Clinica).WithMany(p => p.Ubicaciones)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Ubicaciones_Clinicas");

            entity.HasOne(d => d.Pasillo).WithMany(p => p.Ubicaciones)
                .HasForeignKey(d => d.PasilloId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ubicaciones_Pasillos");
        });

        modelBuilder.Entity<UnidadesMedida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Unidades__3214EC07A6077B93");

            entity.HasIndex(e => e.NombreUnidad, "UQ__Unidades__3C9F658477DB2515").IsUnique();

            entity.HasIndex(e => e.NombreUnidad, "UQ__Unidades__3C9F6584E9E2FCDE").IsUnique();

            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreUnidad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Simbolo)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.TipoUnidadMedida).WithMany(p => p.UnidadesMedida)
                .HasForeignKey(d => d.TipoUnidadMedidaId)
                .HasConstraintName("FK_UnidadesMedidas_TipoUnidadMedida");
        });

        modelBuilder.Entity<Unidosi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Unidosis__3214EC07D7587D55");

            entity.ToTable("Unidosis");

            entity.Property(e => e.Aprobado).HasDefaultValue(false);
            entity.Property(e => e.CantidadTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.Dosis)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaIngreso)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MetodoEnsamblado).HasMaxLength(255);
            entity.Property(e => e.NombreFormula).HasMaxLength(255);
            entity.Property(e => e.NombreRegente).HasMaxLength(50);
            entity.Property(e => e.UnidadMedida).HasMaxLength(50);
            entity.Property(e => e.idNroCaso).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Unidosis)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Unidosis_Clinicas");

            entity.HasOne(d => d.ProductoPaciente).WithMany(p => p.Unidosis).HasForeignKey(d => d.ProductoPacienteId);

            entity.HasOne(d => d.idCedulaPacienteNavigation).WithMany(p => p.Unidosis)
                .HasForeignKey(d => d.idCedulaPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormulaMedica_Pacientes");

            entity.HasOne(d => d.idMedicoNavigation).WithMany(p => p.Unidosis)
                .HasForeignKey(d => d.idMedico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormulaMedica_Medicos");

            entity.HasOne(d => d.idViaAdministracionNavigation).WithMany(p => p.Unidosis)
                .HasForeignKey(d => d.idViaAdministracion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormulaMedica_ViaAdministracion");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC0786D89D73");

            entity.Property(e => e.Cedula)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ConteoUsos).HasDefaultValue(0);
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EsCuentaPrueba).HasDefaultValue(false);
            entity.Property(e => e.EstaEnUso).HasDefaultValue(false);
            entity.Property(e => e.Full_Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ImageProfile)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Inpsasel)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Msas)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.bloqueado).HasDefaultValue(false);
            entity.Property(e => e.browserSession).HasMaxLength(50);
            entity.Property(e => e.dateSession).HasColumnType("datetime");
            entity.Property(e => e.fecha_bloqueo).HasColumnType("datetime");
            entity.Property(e => e.fecha_solicitud_recuperacion).HasColumnType("datetime");
            entity.Property(e => e.fecha_ultimo_cambio_password).HasColumnType("datetime");
            entity.Property(e => e.hostNameSession).HasMaxLength(100);
            entity.Property(e => e.intentos_fallidos).HasDefaultValue(0);
            entity.Property(e => e.ipAddressSession).HasMaxLength(20);
            entity.Property(e => e.soSession).HasMaxLength(50);
            entity.Property(e => e.token_recovery)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_Usuarios_Clinicas");

            entity.HasOne(d => d.Provider).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.ProviderId)
                .HasConstraintName("FK_Usuarios_Proveedores");

            entity.HasOne(d => d.idEspecialidadNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.idEspecialidad)
                .HasConstraintName("FK__Usuarios__idEspe__5C6CB6D7");

            entity.HasOne(d => d.idRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.idRol)
                .HasConstraintName("FK__Usuarios__idRol__1FCDBCEB");

            entity.HasOne(d => d.idStatusNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.idStatus)
                .HasConstraintName("FK__Usuarios__idStat__20C1E124");
        });

        modelBuilder.Entity<UsuarioClinica>(entity =>
        {
            entity.HasIndex(e => new { e.UsuarioId, e.ClinicaId }, "UQ_Usuario_Clinica").IsUnique();

            entity.HasOne(d => d.Clinica).WithMany(p => p.UsuarioClinicas)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_UsuarioClinicas_Clinicas");

            entity.HasOne(d => d.Rol).WithMany(p => p.UsuarioClinicas)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioClinicas_Rol");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioClinicas)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_UsuarioClinicas_Usuarios");
        });

        modelBuilder.Entity<Valore>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Valor).HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.IdImpuestosNavigation).WithMany()
                .HasForeignKey(d => d.IdImpuestos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Valores__IdImpue__629A9179");
        });

        modelBuilder.Entity<ValoresImpuesto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ValoresI__3214EC077DBD273E");

            entity.Property(e => e.Valor).HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.idImpuestoNavigation).WithMany(p => p.ValoresImpuestos)
                .HasForeignKey(d => d.idImpuesto)
                .HasConstraintName("FK__ValoresIm__idImp__6482D9EB");
        });

        modelBuilder.Entity<ValoresSegmento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ValoresSegmentos_Id");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Codigo).IsUnicode(false);
            entity.Property(e => e.Creado).HasColumnType("datetime");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.Modificado).HasColumnType("datetime");
            entity.Property(e => e.Valor).IsUnicode(false);
        });

        modelBuilder.Entity<ViaAdministracion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ViaAdmin__3214EC074FEB8639");

            entity.ToTable("ViaAdministracion");

            entity.Property(e => e.Via).HasMaxLength(50);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ViaAdministracions)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ViaAdministracion_Clinicas");
        });

        modelBuilder.Entity<ZonaExamenFisico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ZonaExam__3214EC072492EEC5");

            entity.ToTable("ZonaExamenFisico");

            entity.Property(e => e.Zona)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinica).WithMany(p => p.ZonaExamenFisicos)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_ZonaExamenFisico_Clinicas");

            entity.HasOne(d => d.idExamen_ExamenFisicoNavigation).WithMany(p => p.ZonaExamenFisicos)
                .HasForeignKey(d => d.idExamen_ExamenFisico)
                .HasConstraintName("FK__ZonaExame__idExa__675F4696");
        });

        modelBuilder.Entity<pruebaitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pruebait__3214EC07CF6AFFBF");

            entity.Property(e => e.CostoParticular).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoSeguro).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Clinica).WithMany(p => p.pruebaitems)
                .HasForeignKey(d => d.ClinicaId)
                .HasConstraintName("FK_pruebaitems_Clinicas");

            entity.HasOne(d => d.idCategoriaItemsNavigation).WithMany(p => p.pruebaitems)
                .HasForeignKey(d => d.idCategoriaItems)
                .HasConstraintName("FK__pruebaite__idCat__46335CF5");

            entity.HasOne(d => d.idClientesNavigation).WithMany(p => p.pruebaitems)
                .HasForeignKey(d => d.idClientes)
                .HasConstraintName("FK__pruebaite__idCli__6ADAD1BF");

            entity.HasOne(d => d.idTipoIVANavigation).WithMany(p => p.pruebaitems)
                .HasForeignKey(d => d.idTipoIVA)
                .HasConstraintName("FK__pruebaite__idTip__490FC9A0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
