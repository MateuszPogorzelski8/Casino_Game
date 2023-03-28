using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class Ruletka_gra
    {
        public decimal liczba_gra(int wylosowana, decimal stawka, int wybrana, int ile)
        {
            if (wylosowana == wybrana)
            {
                return stawka *= (ile-1);
            }
            else
            {
                return -stawka;
                
            }
        }
        public decimal kolor_gra(string wylosowana, decimal stawka, string wybrana, int ile)
        {
            if (wylosowana == wybrana)
            {
                return stawka * ile;
            }
            else
            {
                return -stawka;
            }
        }
    }
}
