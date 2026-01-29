using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Estudio
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? CodigoEstudio { get; set; }

    public string? NroFactura { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public DateTime? FechaRegistroFactProveedor { get; set; }

    public int? idStatusFacturacion { get; set; }

    public int? idCategoriaItems { get; set; }

    public int? idItems { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? PDFOrden { get; set; }

    public string? PDFFactura { get; set; }

    public int? idTipoRayosX { get; set; }

    public int? idCantidadProyeccionesRayosX { get; set; }

    public bool? Informe { get; set; }

    public string? InformePDF { get; set; }

    public decimal? TotalDivisas { get; set; }

    public decimal? TotalBs { get; set; }

    public decimal? PorPagar { get; set; }

    public int? idTipoCliente { get; set; }

    public int? idClinetes { get; set; }

    public string? OrdenEstudioSeguro { get; set; }

    public decimal? TasaCambio { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual CantidadProyeccionesRayosX? idCantidadProyeccionesRayosXNavigation { get; set; }

    public virtual CategoriaItem? idCategoriaItemsNavigation { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Cliente? idClinetesNavigation { get; set; }

    public virtual Item? idItemsNavigation { get; set; }

    public virtual StatusFacturacion? idStatusFacturacionNavigation { get; set; }

    public virtual TipoCliente? idTipoClienteNavigation { get; set; }

    public virtual TipoRayosX? idTipoRayosXNavigation { get; set; }
}
