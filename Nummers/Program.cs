using System;

namespace Nummers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maak een klasse Nummers.Deze klasse bevat 2 getallen (type int) die via een autoproperty kunnen aangepast worden.Er zijn 4 methoden:

            //Som: geeft de som van beide getallen terug
            //Verschil: geeft het verschil van beide getallen terug
            //Product: geeft het product van beide getallen terug
            //Quotient: geeft de deling van beide getallen terug.Toon "Error" indien je zou moeten delen door 0.

            Nummers nummers = new Nummers();
            Console.WriteLine("Hello World, Let's do some Math!");
            Console.WriteLine();

            nummers.getal1 = 45;
            nummers.getal2 = 0;

            nummers.PrintBerekeningen();
            

        }
    }
}
