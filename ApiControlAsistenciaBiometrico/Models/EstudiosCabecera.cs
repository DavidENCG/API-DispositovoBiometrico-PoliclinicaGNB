using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class EstudiosCabecera
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idTipoCliente { get; set; }

    public int? idCliente { get; set; }

    public string? CodigoEstudio { get; set; }

    public int? idStatusFacturacion { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? PDFOrden { get; set; }

    public string? PDFFactura { get; set; }

    public bool? Informe { get; set; }

    public string? InformePDF { get; set; }

    public decimal? TotalDivisas { get; set; }

    public decimal? TotalBs { get; set; }

    public decimal? PorPagar { get; set; }

    public DateOnly? FechaSolicitud { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Cliente? idClienteNavigation { get; set; }

    public virtual StatusFacturacion? idStatusFacturacionNavigation { get; set; }

    public virtual TipoCliente? idTipoClienteNavigation { get; set; }
}
