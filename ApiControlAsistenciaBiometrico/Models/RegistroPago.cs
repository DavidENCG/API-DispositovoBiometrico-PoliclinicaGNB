using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class RegistroPago
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public int? idFormaPago { get; set; }

    public decimal? MontoBs { get; set; }

    public decimal? MontoDivisas { get; set; }

    public string? Referencia { get; set; }

    public string? Notas { get; set; }

    public int? UserRegister { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ClinicaId { get; set; }

    public int? ClientesId { get; set; }

    public int? PresupuestoId { get; set; }

    public int? TipoClienteId { get; set; }

    public int? TipoPagoId { get; set; }

    public virtual Cliente? Clientes { get; set; }

    public virtual Clinica? Clinica { get; set; }

    public virtual Presupuesto? Presupuesto { get; set; }

    public virtual TipoPago? TipoPago { get; set; }

    public virtual Usuario? UserRegisterNavigation { get; set; }

    public virtual FormasPago? idFormaPagoNavigation { get; set; }
}
