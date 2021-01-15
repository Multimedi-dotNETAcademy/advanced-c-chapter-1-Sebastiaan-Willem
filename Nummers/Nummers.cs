using System;
using System.Collections.Generic;
using System.Text;

namespace Nummers
{
    class Nummers
    {
        //Maak een klasse Nummers.Deze klasse bevat 2 getallen (type int) die via een autoproperty kunnen aangepast worden.Er zijn 4 methoden:

        //Som: geeft de som van beide getallen terug
        //Verschil: geeft het verschil van beide getallen terug
        //Product: geeft het product van beide getallen terug
        //Quotient: geeft de deling van beide getallen terug.Toon "Error" indien je zou moeten delen door 0.

        public int getal1 { get; set; }
        public int getal2 { get; set; }


        public int Som()
        {                 
            return getal1 + getal2;            
        }
        public int Verschil()
        {
            return getal1 - getal2;
        }
        public int Product()
        {
            return getal1 * getal2;
        }
        public double Quotient()
        {
            
            while(getal2 == 0)
            {
                Console.WriteLine("Delen door nul is niet mogelijk.");
                Console.WriteLine("Geef een nieuwe waarde in om door te delen.");
                getal2 = Convert.ToInt32(Console.ReadLine());
            }
            
            return getal1 / (double)getal2;
        }

        public void PrintBerekeningen()
        {
            Console.WriteLine($"De getallen {getal1} en {getal2}: ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"De Som is: {Som()} ");
            Console.WriteLine($"Het verschil is: {Verschil()} ");
            Console.WriteLine($"Het product is: {Product()} ");
            Console.WriteLine($"Het quotient is: {Quotient()} ");
        }

    }
}
