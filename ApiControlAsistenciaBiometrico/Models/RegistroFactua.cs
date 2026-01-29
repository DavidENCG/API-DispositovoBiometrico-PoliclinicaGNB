using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class RegistroFactua
{
    public int Id { get; set; }

    public int? idPaciente { get; set; }

    public int? idNroFactura { get; set; }

    public int? idCitasMedicas { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Total { get; set; }

    public string? IVA { get; set; }

    public string? IFGT { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ClinicaId { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual CitasMedica? idCitasMedicasNavigation { get; set; }

    public virtual NroFactura? idNroFacturaNavigation { get; set; }

    public virtual Paciente? idPacienteNavigation { get; set; }
}
