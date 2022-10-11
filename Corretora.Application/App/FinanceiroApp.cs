using Corretora.Application.Interfaces;
using Corretora.Domain.Core;
using Corretora.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Corretora.Application.App
{
    public class FinanceiroApp : IFinanceiroApp
    {
        private readonly ICIFService _iCIFService;

        public FinanceiroApp(ICIFService iCIFService)
        {
            _iCIFService = iCIFService;
        }

        public string EMAeMACDGrafico(List<Cotacao> cotacoes)
        {
            var dados = new List<List<double>>();
            for (int i = 0; i < cotacoes.Count; i++)
            {
                var dado = new List<double>();
                dado.Add(cotacoes.ElementAt(i).Data.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds);
                dado.Add((double)cotacoes.ElementAt(i).Abertura);
                dado.Add((double)cotacoes.ElementAt(i).Alta);
                dado.Add((double)cotacoes.ElementAt(i).Baixa);
                dado.Add((double)cotacoes.ElementAt(i).Fechamento);
                dados.Add(dado);
            }
            return JsonSerializer.Serialize(dados);
        }

        public Grafico EMAeMACDList(List<Cotacao> cotacoes)
        {
            var valoresEma9     = _iCIFService.CalcularEma(cotacoes, 9);
            var valoresEma12    = _iCIFService.CalcularEma(cotacoes, 12);
            var valoresEma26    = _iCIFService.CalcularEma(cotacoes, 26);
            var valoresMacd     = _iCIFService.CalcularMacd(cotacoes);

            return new Grafico(cotacoes.ToList(), valoresEma9.Result, valoresEma12.Result, valoresEma26.Result, valoresMacd.Result);
        }
    }
}
