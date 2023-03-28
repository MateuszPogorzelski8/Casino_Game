using Microsoft.AspNetCore.Mvc;
using API;
using System.Drawing.Printing;
using NuGet.Packaging;

namespace WEB_API_PROJEKT_2022_7._0.Services
{
    // API can run without this service. It is just a template for future expansions.
    public class PlayersService : API.IService1
    {
        private readonly IService1 playersService;

        public PlayersService(API.Service1Client _gamer)
        {
            playersService = _gamer;
        }

        public async Task Ban_PlayerAsync(string login)
        {
            await playersService.Ban_PlayerAsync(login);
        }

        public async Task<string> Change_PasswordAsync(string login, string password, string new_password)
        {
            return await playersService.Change_PasswordAsync(login, password, new_password);
        }

        public async Task Delete_PlayerAsync(string login)
        {
            await playersService.Delete_PlayerAsync(login);
        }

        public Task Deposit_MoneyAsync(string token, decimal money)
        {
            return Task.CompletedTask;
        }

        public Task<Player> GetPlayerAsync(string login)
        {
            return playersService.GetPlayerAsync(login);
        }

        public Task<Player[]> GetPlayersAsync()
        {
            return playersService.GetPlayersAsync();
        }

        public async Task<Player[]> GetPlayersByAsync(string login)
        {
            return await playersService.GetPlayersByAsync(login);
        }

        public async Task<string> LoginAsync(string login, string password)
        {
            return await playersService.LoginAsync(login, password);
        }

        public async Task<bool> RegisterAsync(string login, string password)
        {
            return await playersService.RegisterAsync(login, password);
        }

        public Task Update_MoneyAsync(string token, decimal money)
        {
            return Task.CompletedTask;
        }
        
    }
}
