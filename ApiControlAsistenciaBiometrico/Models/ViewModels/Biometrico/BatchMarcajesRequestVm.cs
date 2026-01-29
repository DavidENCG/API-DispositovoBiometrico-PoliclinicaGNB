namespace ApiControlAsistenciaBiometrico.Models.ViewModels.Biometrico
{
    public class BatchMarcajesRequestVm
    {
        public string AgentKey { get; set; } = default!;        // identifica el Windows Service/PC
        public int DispositivoId { get; set; }
        public int? ClinicaId { get; set; }                     // opcional (si lo manejas desde agente)
        public List<MarcajeDto> Marcajes { get; set; } = new();

    }
}
