namespace Corretora.Domain.Core.Interfaces.Services
{
    public interface ICIFService
    {
        Task<IEnumerable<Ema>> CalcularEma(IEnumerable<Cotacao> cotacoesx, int dias);
        Task<IEnumerable<Macd>> CalcularMacd(IEnumerable<Cotacao> cotacoes);
    }
}
