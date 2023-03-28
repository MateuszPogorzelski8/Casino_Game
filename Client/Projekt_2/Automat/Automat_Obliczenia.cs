using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class Automat_Obliczenia
    {
        public int[] Automat_Obliczenia_exe()
        {
            int[] liczby=new int[3];
            Random rnd = new Random();
            for(int i=0; i<liczby.Length; i++)
            {
                
                liczby[i] = rnd.Next(0, 3);
                
            }

            if (liczby[0] == liczby[1] && liczby[1]==liczby[2])
            {
                
                return liczby;
            }
            else
            {
               
                return liczby;   
            }

        }
    }
}
