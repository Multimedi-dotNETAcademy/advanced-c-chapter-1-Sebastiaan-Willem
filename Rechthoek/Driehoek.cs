using System;
using System.Collections.Generic;
using System.Text;

namespace Figuren
{
    class Driehoek
    {
        private int basis;
        private int hoogte;
        private bool aangepast = false;


        public int Basis
        {
            get
            {
                return basis;
            }
            set
            {
                if (value < 1)
                {
                   basis = 1;
                   aangepast = true;
                }
                else
                    basis = value;
            }
        }

        public int Hoogte
        {
            get
            {
                return hoogte;
            }
            set
            {
                if (value < 1)
                {
                    hoogte = 1;
                    aangepast = true;
                }
                else
                    hoogte = value;
            }
        }

        public Driehoek()
        {

        }
        public Driehoek(int basis, int hoogte)
        {
            Basis = basis;
            Hoogte = hoogte;
        }

        public void ToonOppervlakte()
        {
            double oppervlakte = (basis * hoogte)/2.0;
            if(aangepast)
            {
                Console.WriteLine($"De oppervlakte van deze driehoek met basis {basis} en hoogte {hoogte} is {oppervlakte}². <<< Deze waarde werd aangepast wegens foutieve invoer >>>");
            }
            else
                Console.WriteLine($"De oppervlakte van deze driehoek met basis {basis} en hoogte {hoogte} is {oppervlakte}²");
            
        }
    }
}
