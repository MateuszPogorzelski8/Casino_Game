using Microsoft.AspNetCore.Mvc;
using WEB_API_PROJEKT_2022_7._0.Models;
using WEB_API_PROJEKT_2022_7._0.Services;
using API;

namespace WEB_API_PROJEKT_2022_7._0.Controllers
{
    public class GraczeController : Controller
    {

        Service1Client service = new Service1Client();


        public GraczeController()
        {
            API.Service1Client _service = new API.Service1Client();
            service = _service;
            
        }


        public async Task<IActionResult> Index()
        {
            
            return View(await service.GetPlayersAsync());

        }
        [HttpPost]
        public async Task<IActionResult> Index(string username)
        {
            if (username == null)
            {
                return View(await service.GetPlayersAsync());
            }
            else
            {
                return View(await service.GetPlayersByAsync(username));
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(string name, string password)
        {
            await service.RegisterAsync(name, password);
        
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(string name)
        {
            var gracz = service.GetPlayerAsync(name);
            return View(await gracz);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string name, string password, string new_password)
        {
            string wynik = await service.Change_PasswordAsync(name, password, new_password);
            if(wynik == "SUCCESS")
            {
                return RedirectToAction("Index");
            }
            else if(wynik == "Old and new password must differ")
            {
                return View();
            }
            else
            {
                return View();
            }
            
        }

        public async Task<IActionResult> Delete(string name) 
        {
            await service.Delete_PlayerAsync(name);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Ban(string name)
        {
            await service.Ban_PlayerAsync(name);
            return RedirectToAction("Index");
        }
        
    }
}
