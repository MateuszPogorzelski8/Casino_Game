using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie i pliku konfiguracji.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {

        List<Player> players = new List<Player>();

        public Player GetPlayer(string login)
        {
            return players.Find(x => x.Name == login);
        }

        public Player[] GetPlayers()
        {
            return players.ToArray();
        }

        public string Login(string login, string password)
        {
            if(players.Any(p => p.Name == login && p.Password == password)){
                string token = Guid.NewGuid().ToString();
                players.Find(p => p.Name == login && p.Password == password).Token = token;
                return token;
            }
            if (players.Any(p => p.Name.EndsWith(login) && p.Password == password && p.Name.StartsWith("[BAN]"))){

                players.Find(p => p.Name.EndsWith(login) && p.Password == password && p.Name.StartsWith("[BAN]")).Token = "BAN";
                return "BAN";
            }
            else
            {
                return string.Empty;
            }
        }
        public string Change_Password(string login, string password, string new_password)
        {
            if (players.Any(p => p.Name == login && p.Password == password && p.Password != new_password))
            {
                players.Find(p => p.Name == login && p.Password == password).Password = new_password;
                return "SUCCESS";
            }
            if (players.Any(p => p.Name == login && p.Password == password && p.Password == new_password))
            {
                return "Old and new password must differ";
            }
            else return string.Empty;
        }

        public bool Register(string login, string password)
        {
            if(players.Any(p => p.Name==login))
            {
                return false;
            }
            else
            {
                lock (players)
                {
                    Player nowy_gracz = new Player();


                    nowy_gracz.Name = login;
                    nowy_gracz.Password = password;
                    nowy_gracz.Cash = 10;

                    players.Add(nowy_gracz);
                    
                } return true;
            }
        }

        public void Deposit_Money(string token, decimal money)
        {
            
            if(players.Find(x => x.Token == token)!=null)
                {
                    players.Find(x => x.Token == token).Cash += money;

            }
            else
            {
                token= string.Empty;
            }
                    
        }
        public void Update_Money(string token, decimal money)
        {
            players.Find(x => x.Token==token).Cash = money;
        }

        public void Ban_Player(string login)
        {
            var gamer = players.Find(x => x.Name.Contains(login));

            if (!gamer.Name.StartsWith("[BAN]") && gamer.Name.Contains(login))
            {
                   players.Find(p => p.Name == login).Name ="[BAN]" + login;
            }
            else if (gamer.Name.StartsWith("[BAN]") && gamer.Name.Contains(login))
            {
               string new_name = players.Find(p => p.Name.EndsWith(login)).Name.Remove(0, 5);
               players.Find(p => p.Name.EndsWith(login)).Name=new_name;
            }
        }

        public void Delete_Player(string login)
        {
            if(login == null) { }
            else if (players.Find(p => p.Name == login || p.Name.StartsWith("[BAN]") && p.Name.EndsWith(login))!=null)
            {
                players.Remove(players.Find(p => p.Name == login || p.Name.StartsWith("[BAN]") && p.Name.EndsWith(login)));
            }
            else { }
        }
        public Player[] GetPlayersBy(string name)
        {
            
            List<Player> list = new List<Player>();

            foreach (var p in players)
            {
                if (p.Name.Contains(name))
                {
                    list.Add(p);
                }
                else { }

            }
            return list.ToArray();
        }
    }
}
