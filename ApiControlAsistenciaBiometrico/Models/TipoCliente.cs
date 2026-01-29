using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class TipoCliente
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<CitasMedica> CitasMedicas { get; set; } = new List<CitasMedica>();

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<EstudiosCabecera> EstudiosCabeceras { get; set; } = new List<EstudiosCabecera>();

    public virtual ICollection<SegurosPaciente> SegurosPacientes { get; set; } = new List<SegurosPaciente>();

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
}
