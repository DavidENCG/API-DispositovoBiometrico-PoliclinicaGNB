namespace ApiControlAsistenciaBiometrico.Models.ViewModels.Biometrico
{
    public class DispositivoResponseVm
    {
        public int Id { get; set; }
        public int? ClinicaId { get; set; }
        public string Nombre { get; set; } = default!;
        public string? Serial { get; set; }
        public bool Activo { get; set; }
        public DateTime? UltimoSyncUtc { get; set; }
    }
}
