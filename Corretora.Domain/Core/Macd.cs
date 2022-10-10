namespace Corretora.Domain.Core
{
    public class Macd : Entity<Guid>
    {
        public DateTime Data { get; internal set; }
        public decimal Valor { get; internal set; }
        public decimal ValorSignal { get; internal set; }
        public decimal ValorHistorico { get; internal set; }
    }
}
