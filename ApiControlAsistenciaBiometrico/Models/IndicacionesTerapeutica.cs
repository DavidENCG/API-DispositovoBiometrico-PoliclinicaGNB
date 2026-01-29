using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class IndicacionesTerapeutica
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public string? idNroCaso { get; set; }

    public string? Dosis { get; set; }

    public int? idViaAdministracion { get; set; }

    public string? Indicaciones { get; set; }

    public int? idMedico { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? ClinicaId { get; set; }

    public string? PrefijoDepartamento { get; set; }

    public string? Observacion { get; set; }

    public bool? Aprobado { get; set; }

    public int? ProductoId { get; set; }

    public string? NombreRegente { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Producto? Producto { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }

    public virtual ViaAdministracion? idViaAdministracionNavigation { get; set; }
}
