using API;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WEB_API_PROJEKT_2022_7._0.Models;

namespace WEB_API_PROJEKT_2022_7._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            Service1Client game = new Service1Client();

            // Uncomment if want to use Mock Service

            //string[] uzytkownicy = { "Krzysztof", "Mateusz", "Hubert" };
            return View(await game.GetPlayersAsync());
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

        public IActionResult Application()
        {
            return View();
        }
    }
}