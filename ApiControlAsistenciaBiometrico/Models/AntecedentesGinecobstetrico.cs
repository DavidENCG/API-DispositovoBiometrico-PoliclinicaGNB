using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class AntecedentesGinecobstetrico
{
    public int Id { get; set; }

    public int? idCedulaPaciente { get; set; }

    public int? idMedico { get; set; }

    public DateTime? FechaMenarquia { get; set; }

    public DateTime? MenstruacionUltimaFecha { get; set; }

    public int? idFrecuenciaMenstruacion { get; set; }

    public string? CaracteristicasMenstruacion { get; set; }

    public string? SecrecionVaginal { get; set; }

    public bool? idDismenorrea { get; set; }

    public string? AlteracionMenstruacion { get; set; }

    public bool? idActividadSexual { get; set; }

    public bool? idMolestiasActoSexual { get; set; }

    public string? MetodoAnticonceptivo { get; set; }

    public DateTime? FechaAnticonceptivo { get; set; }

    public int? NroEmbarazos { get; set; }

    public int? Partos { get; set; }

    public int? Cesareas { get; set; }

    public int? Abortos { get; set; }

    public int? NacidosVivos { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Paciente? idCedulaPacienteNavigation { get; set; }

    public virtual FrecuenciaMenstruacion? idFrecuenciaMenstruacionNavigation { get; set; }

    public virtual Usuario? idMedicoNavigation { get; set; }
}
