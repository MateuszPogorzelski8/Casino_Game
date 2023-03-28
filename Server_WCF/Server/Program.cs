using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCF;
using System.Threading;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service1 game = new Service1();
            game.Register("admin", "admin1");
            game.Register("john", "john1");
            game.Register("marc", "marc1");

            ServiceHost host_server = new ServiceHost(game);

            Console.WriteLine("Oppening server connection...");
            host_server.Opened += Host_server_Opened;
            host_server.Open();
            Console.WriteLine("-------------------------------------------");


        while(true)
            {
                Console.SetCursorPosition(0, 2);

                Console.WriteLine("Lista graczy: ");

                foreach(var p in game.GetPlayers().ToArray())
                {
                    Console.WriteLine(p.Name +" "+ p.Cash+ " $ " + p.Password);

                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        private static void Host_server_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Server connection has been opened.");
            
        }
    }
}
