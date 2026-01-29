namespace ApiControlAsistenciaBiometrico.Models.ViewModels.Biometrico
{
    public class BatchMarcajesResponseVm
    {
        public int Recibidos { get; set; }
        public int Insertados { get; set; }
        public int Duplicados { get; set; }
        public int Rechazados { get; set; }

        public DateTime ServerUtc { get; set; }
    }
}
