using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzd1
{

    class uzduotis {
        public double c;
        public int i;

        public static void daryti() {

            double daug = Math.Pow(10, 15);
            double a = 1;
            double b = 2;
            double c = 0;
            int i = 0;

            while (c <= daug) {
                c = a * b;
                a = b;
                b = c;
                i++;
            }

            Console.WriteLine("Ats.: " + c);
            Console.WriteLine("Prasukta: " + i + " kartus.");

        }
        

    }

}
       
        
