using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Especialidade
{
    public int Id { get; set; }

    public string? Especialidad { get; set; }

    public decimal? CostoConsulta { get; set; }

    public int? idTipoIVA { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<CitasMedica> CitasMedicas { get; set; } = new List<CitasMedica>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<EspecialidadesMedico> EspecialidadesMedicos { get; set; } = new List<EspecialidadesMedico>();

    public virtual ICollection<ServicioDetalle> ServicioDetalles { get; set; } = new List<ServicioDetalle>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual TipoIVA? idTipoIVANavigation { get; set; }
}
