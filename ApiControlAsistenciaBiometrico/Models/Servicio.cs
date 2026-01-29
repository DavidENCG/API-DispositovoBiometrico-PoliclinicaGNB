using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Servicio
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idTipoCliente { get; set; }

    public int? idCliente { get; set; }

    public int? idStatusFacturacion { get; set; }

    public decimal? TotalDivisas { get; set; }

    public decimal? TotalBs { get; set; }

    public decimal? TasaCambio { get; set; }

    public decimal? PorPagar { get; set; }

    public int? idStatusCaso { get; set; }

    public int? idStatusCita { get; set; }

    public string? PDFFactura { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public int? idEstadoOrdenSeguro { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? idPrefijosCasos { get; set; }

    public bool? EnEspera { get; set; }

    public DateTime? FechaCorreoProveedor { get; set; }

    public int? ClinicaId { get; set; }

    public int? UbicacionID { get; set; }

    public string? Sintomas { get; set; }

    public decimal? TotalCargos { get; set; }

    public decimal? TotalAbonos { get; set; }

    public decimal? Balance { get; set; }

    public string? Autor { get; set; }

    public string? CodigoTratante { get; set; }

    public DateTime? FechaAbono { get; set; }

    public decimal? MontoAsegurado { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? MotivoAlta { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Imagene> Imagenes { get; set; } = new List<Imagene>();

    public virtual ICollection<ImpuestoServicio> ImpuestoServicios { get; set; } = new List<ImpuestoServicio>();

    public virtual ICollection<Odontograma> Odontogramas { get; set; } = new List<Odontograma>();

    public virtual ICollection<Poliza> Polizas { get; set; } = new List<Poliza>();

    public virtual ICollection<ReservaEmergencium> ReservaEmergencia { get; set; } = new List<ReservaEmergencium>();

    public virtual ICollection<ReservaHospitalizacion> ReservaHospitalizacions { get; set; } = new List<ReservaHospitalizacion>();

    public virtual ICollection<ServiciosProveedore> ServiciosProveedores { get; set; } = new List<ServiciosProveedore>();

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Cliente? idClienteNavigation { get; set; }

    public virtual EstadoOrdenSeguro? idEstadoOrdenSeguroNavigation { get; set; }

    public virtual PrefijosCaso? idPrefijosCasosNavigation { get; set; }

    public virtual StatusCaso? idStatusCasoNavigation { get; set; }

    public virtual StatusCitum? idStatusCitaNavigation { get; set; }

    public virtual StatusFacturacion? idStatusFacturacionNavigation { get; set; }

    public virtual TipoCliente? idTipoClienteNavigation { get; set; }
}
