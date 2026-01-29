using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class StatusFacturacion
{
    public int Id { get; set; }

    public string? Estado { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<CitasMedica> CitasMedicas { get; set; } = new List<CitasMedica>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<EstudiosCabecera> EstudiosCabeceras { get; set; } = new List<EstudiosCabecera>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
}
