using Corretora.Application.App;
using Corretora.Application.Interfaces;
using Corretora.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Corretora.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAcaoApp _acaoApp;
        private readonly IFinanceiroApp _financeiroApp;

        public HomeController(ILogger<HomeController> logger,
                              IAcaoApp acaoApp,
                              IFinanceiroApp financeiroApp)
        {
            _logger = logger;
            _acaoApp = acaoApp;
            _financeiroApp = financeiroApp;
        }

        public IActionResult Index()
        {
            var acao = _acaoApp.GetAcaoAsync().Result;
            if (acao == null) 
                return View();
            else
            {
                var cotacoes = acao.Cotacoes.OrderBy(c => c.Data).ToList();
                var infGrafico = _financeiroApp.EMAeMACDList(cotacoes);
                return View(EmaMacdToGrafico(infGrafico));
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        private IEnumerable<HomeViewModel> EmaMacdToGrafico(Grafico dadosParaOGrafico)
        {
            var viewModels = new List<HomeViewModel>();

            for (int i = 0; i < dadosParaOGrafico.MenorQuantidade; i++)
            {
                viewModels.Add(
                    new HomeViewModel
                    {
                        Data = dadosParaOGrafico.Cotacoes.ElementAt(i).Data,
                        FechamentoDoDia = dadosParaOGrafico.Cotacoes.ElementAt(i).Fechamento,
                        Ema9 = dadosParaOGrafico.ValoresEma9.ElementAt(i).Valor,
                        Ema12 = dadosParaOGrafico.ValoresEma12.ElementAt(i).Valor,
                        Ema26 = dadosParaOGrafico.ValoresEma26.ElementAt(i).Valor,
                        Macd = dadosParaOGrafico.ValoresMacd.ElementAt(i).Valor,
                        MacdSignal = dadosParaOGrafico.ValoresMacd.ElementAt(i).ValorSignal,
                        MacdHistograma = dadosParaOGrafico.ValoresMacd.ElementAt(i).ValorHistorico
                    }
                );
            }

            return viewModels.OrderByDescending(vm => vm.Data);
        }

    }
}