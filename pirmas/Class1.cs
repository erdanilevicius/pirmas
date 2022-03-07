using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzd
{
    internal class Uzduotis
    {

        public double c = 0;
        public int i = 0;

        public void Daryti()
        {

            double daug = Math.Pow(10, 15);
            double a = 1; // 1 skaic 
            double b = 2; // 2 skaic
            while (c <= daug)
            {
                c = a * b;
                a = b;
                b = c;
                i++;
            }

        }
    }

}
