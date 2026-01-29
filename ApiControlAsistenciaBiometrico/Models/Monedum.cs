using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class Monedum
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? ClinicaId { get; set; }

    public virtual ICollection<BancoMonedum> BancoMoneda { get; set; } = new List<BancoMonedum>();

    public virtual Clinica? Clinica { get; set; }

    public virtual ICollection<OrdenCompra> OrdenCompras { get; set; } = new List<OrdenCompra>();

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
