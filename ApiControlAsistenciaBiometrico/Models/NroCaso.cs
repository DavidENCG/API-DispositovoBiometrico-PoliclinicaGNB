using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class NroCaso
{
    public int Id { get; set; }

    public int? Proveedor { get; set; }

    public int? OrdenCompra { get; set; }

    public int? Producto { get; set; }

    public int? ClinicasId { get; set; }

    public int? Baremo { get; set; }

    public int? Cama { get; set; }

    public int? Categoria { get; set; }

    public int? Cliente { get; set; }

    public int? Factura { get; set; }

    public int? Honorario { get; set; }

    public int? Paciente { get; set; }

    public int? Poliza { get; set; }

    public int? Almacen { get; set; }

    public int? Pasillo { get; set; }

    public int? Presupuesto { get; set; }

    public int? ServicioClinico { get; set; }

    public int? Lote { get; set; }

    public int? Servicio { get; set; }

    public int? Inventario { get; set; }
}
