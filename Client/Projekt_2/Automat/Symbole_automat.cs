using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class Symbole_automat
    {
        public string[] Obrazki(int[] liczby_wylosowane)
        {
            string[] obrazki = { "D:\\kopia\\TEN\\Projekt_2\\Resources\\symbol1.png",
                "D:\\kopia\\TEN\\Projekt_2\\Resources\\symbol2.png",
                "D:\\kopia\\TEN\\Projekt_2\\Resources\\symbol3.png" };

            string[] obrazki_wylosowane = new string[obrazki.Length];
            string y;
            for (int i = 0; i < liczby_wylosowane.Length; i++)
            {
                obrazki_wylosowane[i] = obrazki[liczby_wylosowane[i]];
            }

            return obrazki_wylosowane;
        }
    }
}
