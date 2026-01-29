using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class ServiciosProveedore
{
    public int Id { get; set; }

    public int ProveedorId { get; set; }

    public int ServicioId { get; set; }

    public bool MedicoTratante { get; set; }

    public int? ClinicaId { get; set; }

    public DateOnly Fecha { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Proveedore Proveedor { get; set; } = null!;

    public virtual Servicio Servicio { get; set; } = null!;
}
