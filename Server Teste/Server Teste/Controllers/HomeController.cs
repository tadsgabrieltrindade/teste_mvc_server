using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Server_Teste.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Server_Teste.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PessoaModel pessoa = new PessoaModel();
            pessoa.nome = "Gabriel";
            pessoa.sobrenome = "Ramos Trindade";
            pessoa.Data = DateTime.Now;
            return View(pessoa);
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
