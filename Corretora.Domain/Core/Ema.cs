namespace Corretora.Domain.Core
{
    public class Ema : Entity<Guid>
    {
        public DateTime Data { get; internal set; }
        public decimal Valor { get; internal set; }
    }
}
