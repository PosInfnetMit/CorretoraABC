using Corretora.Domain.Core.Extensions;
using Corretora.Domain.Core.Interfaces.Services;
using Skender.Stock.Indicators;

namespace Corretora.Domain.Core.Services
{
    public class CIFService : ICIFService
    {
        public async Task<IEnumerable<Ema>> CalcularEma(IEnumerable<Cotacao> cotacoes, int dias)
        {
            var quotes = cotacoes.ToQuotes();

            var result = quotes.GetEma(dias);

            var valoresEma = result.Select(r => new Ema
            {
                Data = r.Date,
                Valor =(decimal)r.Ema.GetValueOrDefault()
            });

            return await Task.FromResult(valoresEma);
        }

        public async Task<IEnumerable<Macd>> CalcularMacd(IEnumerable<Cotacao> cotacoes)
        {
            var quotes = cotacoes.ToQuotes();

            var result =  quotes.GetMacd();

            var valoresMacd = result.Select(r => new Macd
            {
                Data = r.Date,
                Valor =  (decimal)r.Macd.GetValueOrDefault(),
                ValorSignal = (decimal)r.Signal.GetValueOrDefault(),
                ValorHistorico = (decimal)r.Histogram.GetValueOrDefault()
            });

            return await Task.FromResult(valoresMacd);
        }
    }
}
