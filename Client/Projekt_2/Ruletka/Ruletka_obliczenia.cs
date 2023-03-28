using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class Ruletka_obliczenia
    {
        private int wylosowana;
        public int Obliczenia(int ile_liczb)
        {
            Random rnd = new Random();
            wylosowana = rnd.Next(1, ile_liczb);



            return wylosowana;

        }
        public string Obliczenia_kolory(string[] kolory, int liczba)
        {
            

            return kolory[liczba-1];
        }

        public int Kolory_prawdopodobienstwo(string[] kolory)
        {
            return kolory.Distinct().Count();

        }
    }
}

