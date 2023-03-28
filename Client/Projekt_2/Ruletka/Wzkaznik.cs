using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class Wzkaznik
    {
        private int[] kolo= {8,3,7,2,5,1,6,4};
        private int wsp = 0;
        double x = 45;
        public double wskaznik (int wylosowana)
        {
           

                for (int i = 0; i < kolo.Length; i++)
                {
                    if (wylosowana == kolo[i])
                    {
                        wsp = kolo[i];
                        x = (x * (i+1) ) - 5;

                    }
                }
                return x;


            }
        }

        
    }

