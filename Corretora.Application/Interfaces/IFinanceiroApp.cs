using Corretora.Application.App;
using Corretora.Domain.Core;

namespace Corretora.Application.Interfaces
{
    public interface IFinanceiroApp
    {
        Grafico EMAeMACDList(List<Cotacao> cotacoes);
        string EMAeMACDGrafico(List<Cotacao> cotacoes);
    }
}
