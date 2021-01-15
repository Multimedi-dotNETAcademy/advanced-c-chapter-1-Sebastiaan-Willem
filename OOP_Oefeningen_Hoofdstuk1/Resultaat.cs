using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Oefeningen_Hoofdstuk1
{
    class Resultaat
    {
        //Ontwerp een klasse Resultaat die je zal tonen wat je graad is gegeven een bepaald behaald percentage.Het enige dat je aan een Resultaat - object moet kunnen geven is het behaalde percentage.Enkel het totaal behaalde % wordt bijgehouden via een auto-property.Via een methode PrintGraad kan de behaalde graad weergegeven worden.Dit zijn de mogelijkheden:

        //    < 50: niet geslaagd;
        //                tussen 50 en 68: voldoende;
        //                tussen 68 en 75: onderscheiding;
        //                tussen 75 en 85: grote onderscheiding;
        //    \> 85: grootste onderscheiding.
        //    Test je klasse door enkele objecten in je main aan te maken en de verschillende properties waarden te geven en methoden aan te roepen.


        private double percentage;

        public void Percentage(double inputPercentage)
        {
            percentage = Math.Round(inputPercentage, 1);
        }


        public void PrintGraad()
        {

            if(percentage < 50)
            {
                Console.WriteLine($"De behaalde graad is <Niet geslaagd>.");
            }
            else if(percentage < 68)
            {
                Console.WriteLine($"De behaalde graad is <Voldoende>.");
            }
            else if (percentage < 75)
            {
                Console.WriteLine($"De behaalde graad is <Onderscheiding>.");
            }
            else if (percentage < 85)
            {
                Console.WriteLine($"De behaalde graad is <Grote Onderscheiding>.");
            }
            else
            {
                Console.WriteLine($"De behaalde graad is <Grootste Onderscheiding>. Proficiat!.");
            }
        }
    }
}
