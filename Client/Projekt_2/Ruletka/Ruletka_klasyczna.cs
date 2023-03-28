using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class Ruletka_klasyczna : Ruletka_dane
    {

        // Tu opisujemy logicznie naszą ruletke
        
        public int[] ile = { 1, 2, 3, 4, 5, 6, 7, 8 };
        public string[] colors = { "B", "B", "B", "B", "R","R", "R", "R" };


        public Ruletka_klasyczna()
        {
            _Liczby = ile;
            _Kolory = colors;
           

        }
        public override int[] Dane_gry_liczby()
        {
           
            return _Liczby;
            
           
        }

        


        public override string[] Dane_gry_kolory()
        {
            
            return _Kolory;
        }

        //
        public override int Daj_size()
        {
            return _Liczby.Length;
        }
        public string[] Daj_kolory()
        {
            return _Kolory;
            
        }
        
    }
}
