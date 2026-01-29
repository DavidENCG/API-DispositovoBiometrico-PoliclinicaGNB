using System;
using System.Collections.Generic;

namespace ApiControlAsistenciaBiometrico.Models;

public partial class DiarioAsientoManualesCabecera
{
    public int Id { get; set; }

    public string? DescripcionDiario { get; set; }

    public bool Registro { get; set; }

    public int ClinicasId { get; set; }

    public string CreadoPor { get; set; } = null!;

    public string? ModificadoPor { get; set; }

    public DateTime Creado { get; set; }

    public DateTime? Modificado { get; set; }

    public virtual Clinica Clinicas { get; set; } = null!;

    public virtual ICollection<DiarioAsientoManualesLinea> DiarioAsientoManualesLineas { get; set; } = new List<DiarioAsientoManualesLinea>();
}
