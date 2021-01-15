using System;

namespace Figuren

{
    class Program
    {
        static void Main(string[] args)
        {
            //array maken om figuren in op te slaan
            Rechthoek[] rechthoeken = new Rechthoek[4];
            Driehoek[] driehoeken = new Driehoek[4];

            

            //aanmaken nieuwe rechthoek objecten adhv constructor met 2 parameters
            Rechthoek rechthoek1 = new Rechthoek(2, 3);
            Rechthoek rechthoek2 = new Rechthoek(0, 3);
            Rechthoek rechthoek3 = new Rechthoek(7, 12);
            Rechthoek rechthoek4 = new Rechthoek(2, 0);
            

            //aanmaken nieuwe driehoek objecten adhv constructor met 2 parameters
            Driehoek driehoek1 = new Driehoek(2, 3);
            Driehoek driehoek2 = new Driehoek(0, 3);
            Driehoek driehoek3 = new Driehoek(2, 0);
            Driehoek driehoek4 = new Driehoek(7, 3);

            //plaatsen van onze objecten in de arrays
            rechthoeken[0] = rechthoek1;
            rechthoeken[1] = rechthoek2;
            rechthoeken[2] = rechthoek3;
            rechthoeken[3] = rechthoek4;

            driehoeken[0] = driehoek1;
            driehoeken[1] = driehoek2;
            driehoeken[2] = driehoek3;
            driehoeken[3] = driehoek4;


            //loop om ToonOppervlakte() methode uit te voeren op elk element van onze array.
            for (int i = 0; i < rechthoeken.Length; i++)
            {
                rechthoeken[i].ToonOppervlakte();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < driehoeken.Length; i++)
            {
                driehoeken[i].ToonOppervlakte();
            }

            
            

            Console.ReadLine();





        }
    }
}
