using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class automat_baner
    {
        public virtual string Baner(int[] numery)
        {
            if (numery[0] == numery[1] && numery[1] == numery[2])
            {
                return "WIN";
            }
            else
            {
                return "LOSE";
            }
        }
    }
}
