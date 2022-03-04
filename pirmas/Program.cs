// See https://aka.ms/new-console-template for more information
//nebūtina
using System;
using static Uzd1.uzduotis; // naudojama klases faile esanti klase
//nebūtina
namespace Uzd
{
    class Programa
    {
        public static void Main(string[] args)
        {

            Uzd1.uzduotis myObj = new Uzd1.uzduotis();

            daryti(); // kvieciama ir vykdoma funkcija daryti esanti "Class1" faile

            Console.WriteLine("Ats.: " + myObj.c);  // nepasiima kintamuju
            Console.WriteLine("Prasukta: " +myObj.i + " kartus.");

        }

    }
}