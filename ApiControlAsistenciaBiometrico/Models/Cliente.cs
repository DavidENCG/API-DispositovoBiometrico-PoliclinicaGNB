using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? DNI_Cliente { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public int? idTipoCliente { get; set; }

    public int? ClinicaId { get; set; }

    public int? GrupoClienteId { get; set; }

    public virtual ICollection<CitasMedica> CitasMedicas { get; set; } = new List<CitasMedica>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<DiarioCobro> DiarioCobros { get; set; } = new List<DiarioCobro>();

    public virtual ICollection<EstadoCuentum> EstadoCuenta { get; set; } = new List<EstadoCuentum>();

    public virtual ICollection<Estudio> Estudios { get; set; } = new List<Estudio>();

    public virtual ICollection<EstudiosCabecera> EstudiosCabeceras { get; set; } = new List<EstudiosCabecera>();

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual ICollection<Poliza> Polizas { get; set; } = new List<Poliza>();

    public virtual ICollection<RegistroPago> RegistroPagos { get; set; } = new List<RegistroPago>();

    public virtual ICollection<SeguroCasosEmergencium> SeguroCasosEmergencia { get; set; } = new List<SeguroCasosEmergencium>();

    public virtual ICollection<SegurosPaciente> SegurosPacientes { get; set; } = new List<SegurosPaciente>();

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();

    public virtual TipoCliente? idTipoClienteNavigation { get; set; }

    public virtual ICollection<pruebaitem> pruebaitems { get; set; } = new List<pruebaitem>();
}
