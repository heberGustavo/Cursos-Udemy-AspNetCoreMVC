using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TempData.Models;

namespace TempData.Controllers
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
            TempData["nome"] = "Heber";
            TempData["idade"] = "22";

            string nome;
            int idade;

            if (TempData.ContainsKey("nome"))
                nome = TempData["nome"].ToString();

            if (TempData.ContainsKey("idade"))
                idade = int.Parse(TempData["idade"].ToString());

            //Para armazena e utilizar em outra tela. Senão usar as variaveis vão vazias
            TempData.Keep();

            return View();
        }

        public IActionResult Privacy()
        {
            string nome;
            int idade; 

            if (TempData.ContainsKey("nome"))
                nome = TempData["nome"].ToString();

            if (TempData.ContainsKey("idade"))
                idade = int.Parse(TempData["idade"].ToString());

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
