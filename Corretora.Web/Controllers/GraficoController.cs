using Corretora.Application.Interfaces;
using Corretora.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Corretora.Web.Controllers
{
    public class GraficoController : Controller
    {
        private readonly IAcaoApp _acaoApp;
        private readonly IFinanceiroApp _financeiroApp;
        private readonly IWebHostEnvironment _webHostEnviroment;
        private readonly string _nomeArquivo = "graf.json";
        public GraficoController(IAcaoApp acaoApp, IFinanceiroApp financeiroApp, IWebHostEnvironment webHostEnviroment)
        {
            _acaoApp = acaoApp;
            _financeiroApp = financeiroApp;
            _webHostEnviroment = webHostEnviroment;
        }

        public IActionResult Index()
        {
            return View(MontarGrafico());
        }

        private GraficoViewModel MontarGrafico()
        {
            var acao = _acaoApp.GetAcaoAsync().Result;
            if (acao == null)
                return null;
            else
            {
                var cotacoes = acao.Cotacoes.OrderBy(c => c.Data).ToList();
                var graficoViewModel = new GraficoViewModel
                {
                    JsonData = _financeiroApp.EMAeMACDGrafico(cotacoes),
                    FilePath = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/Files/{_nomeArquivo}",
                    Acao = acao.Nome
                };

                GerarArquivo(graficoViewModel.JsonData, _nomeArquivo);

                return graficoViewModel;


            }



        }

        private void GerarArquivo(string dados, string nomeArquivo)
        {
            string pasta = "Files";
            string caminho_WebRoot = _webHostEnviroment.WebRootPath;
            string caminhoPastaFile = caminho_WebRoot + "\\" + pasta;

            if (!Directory.Exists(caminhoPastaFile))
            {
                Directory.CreateDirectory(caminhoPastaFile);
            }

            var filePath = Path.Combine(caminhoPastaFile, nomeArquivo);

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            using FileStream fs = System.IO.File.Create(filePath);
            byte[] bytes = new UTF8Encoding(true).GetBytes(dados);
            fs.Write(bytes, 0, bytes.Length);
        }


    }
}
