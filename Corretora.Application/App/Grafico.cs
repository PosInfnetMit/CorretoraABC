using Corretora.Domain.Core;

namespace Corretora.Application.App
{
    public class Grafico
    {

        public IEnumerable<Cotacao> Cotacoes { get; set; }
        public IEnumerable<Ema> ValoresEma9 { get; set; }
        public IEnumerable<Ema> ValoresEma12 { get; set; }
        public IEnumerable<Ema> ValoresEma26 { get; set; }
        public IEnumerable<Macd> ValoresMacd { get; set; }
        public int MenorQuantidade
        {
            get
            {
                var menorIndice = Cotacoes.Count();
                if (ValoresEma9.Count() < menorIndice)
                {
                    menorIndice = ValoresEma9.Count();
                }
                if (ValoresEma12.Count() < menorIndice)
                {
                    menorIndice = ValoresEma12.Count();
                }
                if (ValoresEma26.Count() < menorIndice)
                {
                    menorIndice = ValoresEma26.Count();
                }
                if (ValoresMacd.Count() < menorIndice)
                {
                    menorIndice = ValoresMacd.Count();
                }

                return menorIndice;
            }
        }
        public Grafico(IEnumerable<Cotacao> cotacoes,
                                        IEnumerable<Ema> valoresEma9,
                                        IEnumerable<Ema> valoresEma12,
                                        IEnumerable<Ema> valoresEma26,
                                        IEnumerable<Macd> valoresMacd)
        {
            Cotacoes = cotacoes;
            ValoresEma9 = valoresEma9;
            ValoresEma12 = valoresEma12;
            ValoresEma26 = valoresEma26;
            ValoresMacd = valoresMacd;
        }
    }
}
