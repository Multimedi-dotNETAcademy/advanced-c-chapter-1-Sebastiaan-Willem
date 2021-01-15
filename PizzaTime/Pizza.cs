using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaTime
{
    class Pizza
    {
        private string toppings = "default";
        private int diameter = -1;
        private double prijs = -1;



        public string Toppings 
        {
            get 
            {
                return toppings;
            }
            set
            {
                if(value == "")
                {
                    Console.WriteLine("Geen topping ingegeven.");
                    toppings = "Margherita";
                }
               else
                    toppings = value;
            }
        }
        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                if(value < 10) //kleinste pizza 10cm
                {
                    Console.WriteLine("Geen geldige diameter ingegeven.");
                    diameter = 10;
                }
                else
                    diameter = value;

            }
        }
        public double Prijs
        {
            get
            {
                return prijs;
            }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Geen geldige prijs ingegeven.");
                    prijs = 9.99;
                }
                else
                    prijs = value;

            }
        }
        
        public Pizza()
        {

        }


        public Pizza(string toppings, int diameter, double prijs)
        {
            Toppings = toppings;
            Diameter = diameter;
            Prijs = prijs;
        }

        public void PrintPizza()
        {
            Console.WriteLine($"De pizza <{toppings}> heeft een diameter van {diameter}cm en kost {prijs} euro. ");
        }


    }
}
