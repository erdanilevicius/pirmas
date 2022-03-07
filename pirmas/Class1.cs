using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzd
{

    public class Cons {

        public double a = 1; // 1 skaic 
        public double b = 2; // 2 skaic
        public int prad = 5;
        public Cons()
        {

        }
    

    
    
        }



    internal class Uzduotis : Cons
    {
        public double c;
        public int i;
        public double rezultatas;


        public void Daryti()
        {

            double daug = Math.Pow(10, 15);

            rezultatas = prad;
           
            while (c <= daug)
            {
                this.c = a * b;
                a = b;
                b = c;
                i++;
            }

            for (int f = prad; f > 1; f--) {

                rezultatas = rezultatas * (f - 1);
            
            }



        }

        




    }

}
