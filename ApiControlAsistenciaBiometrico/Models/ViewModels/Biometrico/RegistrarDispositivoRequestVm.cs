namespace ApiControlAsistenciaBiometrico.Models.ViewModels.Biometrico
{
    public class RegistrarDispositivoRequestVm
    {
        public int? ClinicaId { get; set; }
        public string Nombre { get; set; } = default!;
        public string? Serial { get; set; }
        public string? MarcaModelo { get; set; }
    }
}
