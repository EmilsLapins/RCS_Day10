using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pogas
{
    class Kalkulacija
    {


        public static string Saskaita(int a, int b)
        {

            string result = Convert.ToString(a + b);
            return result;
        }

        public static int Atnem(int a, int b)
        {
            int rezultats = a - b;
            return rezultats;
        }

    }
}
