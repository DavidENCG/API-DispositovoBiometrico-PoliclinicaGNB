namespace ApiControlAsistenciaBiometrico.Models.ViewModels.Biometrico
{
    public class MarcajeDto
    {
        public int PersonCode { get; set; }
        public DateTime FechaHoraUtc { get; set; }              // ideal: UTC
        public DateTime? FechaHoraLocal { get; set; }           // opcional
        public string? TipoMarcaje { get; set; }                // "IN" | "OUT" | null
        public long? RecordIdLocal { get; set; }                // si el software local lo trae
    }
}
