using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Unidosi
{
    public int Id { get; set; }

    public string NombreFormula { get; set; } = null!;

    public string? MetodoEnsamblado { get; set; }

    public decimal? CantidadTotal { get; set; }

    public string? Descripcion { get; set; }

    public int idCedulaPaciente { get; set; }

    public string idNroCaso { get; set; } = null!;

    public int idMedico { get; set; }

    public int idViaAdministracion { get; set; }

    public string? Indicaciones { get; set; }

    public string? Observacion { get; set; }

    public bool? Aprobado { get; set; }

    public DateTime FechaIngreso { get; set; }

    public int? ClinicaId { get; set; }

    public string? NombreRegente { get; set; }

    public string? UnidadMedida { get; set; }

    public int? ProductoPacienteId { get; set; }

    public string? Dosis { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<MedicamentoFormula> MedicamentoFormulas { get; set; } = new List<MedicamentoFormula>();

    public virtual Producto? ProductoPaciente { get; set; }

    public virtual Paciente idCedulaPacienteNavigation { get; set; } = null!;

    public virtual Usuario idMedicoNavigation { get; set; } = null!;

    public virtual ViaAdministracion idViaAdministracionNavigation { get; set; } = null!;
}
