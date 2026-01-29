namespace ApiControlAsistenciaBiometrico.Models.ViewModels.Biometrico
{
    public class SyncEstadoResponseVm
    {
        public string AgentKey { get; set; } = default!;
        public int? DispositivoId { get; set; }
        public DateTime? UltimoPushUtc { get; set; }
        public DateTime ServerUtc { get; set; }
    }
}
