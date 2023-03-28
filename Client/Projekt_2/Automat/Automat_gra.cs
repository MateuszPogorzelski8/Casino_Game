using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class Automat_gra
    {
        public virtual decimal Wygrana(int[] liczby, decimal stawka)
        {
            if (liczby[0] == liczby[1] && liczby[1] == liczby[2])
            {
                return stawka *= 9;
            }
            else
            {
                return -stawka;
            }
        }
    }
}

