using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ServicioDetalle
{
    public int Id { get; set; }

    public string? idServicio { get; set; }

    public int? idItems { get; set; }

    public int? idCategoriaItems { get; set; }

    public int? idMedico { get; set; }

    public int? idMotivoConsulta { get; set; }

    public int? idEspecialidad { get; set; }

    public int? idProveedor { get; set; }

    public string? MesServicio { get; set; }

    public string? ConceptoCondominio { get; set; }

    public decimal? Costo { get; set; }

    public bool? Informe { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? Cantidad { get; set; }

    public int? idStatusConsulta { get; set; }

    public string? DescripcionItem { get; set; }

    public int? idProveedorInterno { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual CategoriaItem? idCategoriaItemsNavigation { get; set; }

    public virtual Especialidade? idEspecialidadNavigation { get; set; }

    public virtual Item? idItemsNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }

    public virtual MotivoConsultum? idMotivoConsultaNavigation { get; set; }

    public virtual Usuario? idProveedorInternoNavigation { get; set; }

    public virtual Proveedore? idProveedorNavigation { get; set; }

    public virtual StatusCitum? idStatusConsultaNavigation { get; set; }
}
