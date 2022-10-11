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

        public HomeController(ILogger<HomeController> logger,
                              IAcaoApp acaoApp)
        {
            _logger = logger;
            _acaoApp = acaoApp; 
        }

        public IActionResult Index()
        {
            return View();
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




    }
}