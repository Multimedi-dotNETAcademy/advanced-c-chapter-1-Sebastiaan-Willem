using System;
using System.Collections.Generic;
using System.Text;

namespace Figuren
{
    class Rechthoek
    {
        //Figuren
        //Maak een eenvoudige klasse Rechthoek aan die een lengte en breedte als private datafields heeft.Deze kunnen enkel via full properties ingesteld worden en nooit onder 1 gaan.

        //Maak ook een klasse Driehoek die een basis en hoogte als fields heeft.

        //Beide klassen hebben een methode ToonOppervlakte die de oppervlakte van de figuur in kwestie op het scherm toont.

        //Toon de werking van het project aan door een aantal instanties van Driehoek en Rechthoek te maken, met verschillende groottes.Roep van iedere figuur de ToonOppervlakte-methode aan.


        private int lengte;
        private int breedte;
        private bool aangepast = false;

        

        public int Lengte
        {
            get
            {
                return lengte;
            }
            set 
            {
                if(value < 1)
                {
                    lengte = 1;
                    aangepast = true;
                }
                else
                    lengte = value;
            }
        }

        public int Breedte
        {
            get
            {
                return breedte;
            }
            set
            {
                if (value < 1)
                {
                    breedte = 1;
                    aangepast = true;
                }
                else
                    breedte = value;
            }
        }

        public Rechthoek()
        {

        }
        public Rechthoek(int lengte, int breedte)
        {
            
            Lengte = lengte;
            Breedte = breedte;
        }

        public void ToonOppervlakte()
        {
            int oppervlakte = lengte * breedte;

            if (aangepast)
            {
                Console.WriteLine($"De oppervlakte van deze rechthoek met lengte {lengte} en breedte {breedte} is {oppervlakte}². <<< Deze waarde werd aangepast wegens foutieve invoer. >>> ");
            }
            else
                Console.WriteLine($"De oppervlakte van deze rechthoek met lengte {lengte} en breedte {breedte} is {oppervlakte}²");

        }





    }
}
