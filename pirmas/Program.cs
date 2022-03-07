// See https://aka.ms/new-console-template for more information
//nebūtina
using System;
//using static Uzduotis; // naudojama klases faile esanti klase
//nebūtina
namespace Uzd
{
    internal class Programa
    {
        static void Main(string[] args)
        {

           Uzduotis myObj = new Uzduotis();
           myObj.Daryti();

            //Daryti(); // kvieciama ir vykdoma funkcija daryti esanti "Class1" faile

           Console.WriteLine("Ats.: " + myObj.c);  // nepasiima kintamuju
           Console.WriteLine("Prasukta: " +myObj.i + " kartus.");


            Console.WriteLine("Skaiciaus " + myObj.prad + " faktorialas yra : " + myObj.rezultatas);
            Console.WriteLine("");
         

            DateTime start = DateTime.Now;
            Thread.Sleep(0);
            DateTime end = DateTime.Now;

            TimeSpan ts = (end - start);
            Console.WriteLine("Praejo: " + ts.TotalMilliseconds + " ms");
            while (true) ;

        }

    }
}