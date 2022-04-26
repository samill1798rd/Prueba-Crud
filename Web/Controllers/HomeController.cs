using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.ClienteServices;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClienteServices  _clienteServices;

        public HomeController(ILogger<HomeController> logger, IClienteServices clienteServices)
        {
            _logger = logger;
            _clienteServices = clienteServices;
        }

        public IActionResult Index()
        {
            //var test = _clienteServices.GetCliente();
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
