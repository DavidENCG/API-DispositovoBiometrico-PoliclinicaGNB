using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Solicitud
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public int? idTipoExamaen { get; set; }

    public int? idExamenes { get; set; }

    public string? Observaciones { get; set; }

    public decimal? CostoExamen { get; set; }

    public int? idProveedor { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public string? PreOrdenServicio { get; set; }

    public string? OrdenServicio { get; set; }

    public int? idTipoInterconsulta { get; set; }

    public int? idMedicoInterno { get; set; }

    public int? idInterconsultaEnviada { get; set; }

    public int? idGenerada { get; set; }

    public int? ClinicaId { get; set; }

    public string? PrefijoDepartamento { get; set; }

    public string? RutaDocumento { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Examene? idExamenesNavigation { get; set; }

    public virtual ResRapidum? idGeneradaNavigation { get; set; }

    public virtual ResRapidum? idInterconsultaEnviadaNavigation { get; set; }

    public virtual Usuario? idMedicoInternoNavigation { get; set; }

    public virtual Proveedore? idProveedorNavigation { get; set; }

    public virtual TipoExaman? idTipoExamaenNavigation { get; set; }

    public virtual TipoInterconsultum? idTipoInterconsultaNavigation { get; set; }
}
