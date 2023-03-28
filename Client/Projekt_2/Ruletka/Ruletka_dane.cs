using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    abstract class Ruletka_dane
    {

        protected int[] _Liczby { get; set; }
        protected string[] _Kolory { get; set; }
        

        public abstract int[] Dane_gry_liczby();
        public abstract string[] Dane_gry_kolory();
        public abstract int Daj_size();

       
    }
}
