using System;
using System.Collections.Generic;
using System.Text;

namespace StudentKlasse
{
    public enum Klasgroep { EA1 = 1, EA2, EA3, EA4, }
    class Student
    {
        //        Maak een nieuwe klasse Student.

        //Deze klasse heeft 6 autoproperties:

        //Naam(string)
        //Leeftijd(int)
        //Klas(maak dit van een enum)
        //PuntenCommunicatie(int)
        //PuntenProgrammingPrinciples(int)
        //PuntenWebTech(int)
        //Voeg aan de klasse een methode BerekenTotaalCijfer toe.Wanneer deze methode wordt aangeroepen dan wordt het gemiddelde van de 3 punten teruggegeven als double zodat dit op het scherm kan getoond worden.

        //Voeg aan de klasse ook de methode GeefOverzicht toe.Deze methode zal een volledig "Rapport" van de student tonen (inclusief het gemiddelde m.b.v.de BerekenTotaalCijfer-methode).

        //Test je programma door enkele studenten aan te maken en in te stellen.Volgende main zou dan de bijhorende output moeten krijgen:


        public string Naam {get;set;}
        public int Leeftijd { get; set; }

        public int PuntenCommunicatie { get; set; }
        public int PuntenProprammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }
        public Klasgroep Klas { get; set; }

        public Student()
        {
            //empty constructor, wordt automatisch gebruikt als er geen andere gedefinieerd is dus hoef je in principe niet te schrijven.
        }


        //Constructor overload met parameters om de Properties onmiddellijk in te vullen.
        public Student(string naamStudent, int leeftijdStudent, Klasgroep klasgroep, int puntenCom, int puntenProg, int puntenWeb)
        {
            Naam = naamStudent;
            Leeftijd = leeftijdStudent;
            Klas = klasgroep;
            PuntenCommunicatie = puntenCom;
            PuntenProprammingPrinciples = puntenProg;
            PuntenWebTech = puntenWeb;

        }
        

        private double BerekenTotaalCijfer()
        {
            double resultaat = Math.Round((double)(PuntenCommunicatie + PuntenProprammingPrinciples + PuntenWebTech) / 3, 1);
            return resultaat;
        }

        public void Rapport()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} - {Klas}, {PuntenCommunicatie}, {PuntenProprammingPrinciples} , {PuntenWebTech}, {BerekenTotaalCijfer()}");
        }


        public void VoegStudentToe()
        {
            AskName();
            AskAge();
            AskKlas();
            AskPuntenCom();
            AskPuntenProg();
            AskPuntenWeb();
        }
        private void AskName()
        {
            Console.WriteLine("Gelieve een naam in te voeren");
            Naam = Console.ReadLine();
        }

        private void AskAge()
        {
            Console.WriteLine("Gelieve een leeftijd in te voeren");
            Leeftijd = Convert.ToInt32(Console.ReadLine());
        }
        private void AskKlas()
        {
            Console.WriteLine("Gelieve de klas in te voeren adhv een nummer: (EA1 = 1 , EA2 = 2, EA3 = 3, of EA4 = 4)");
            Klas = (Klasgroep)Enum.Parse(typeof(Klasgroep), Console.ReadLine());
                //Convert.ToString(Enum.Parse(typeof(Klasgroep), Console.ReadLine()));
                
        }
        private void AskPuntenCom()
        {
            Console.WriteLine("puntenCommunicatie");
            PuntenCommunicatie = Convert.ToInt32(Console.ReadLine());
        }
        
        private void AskPuntenProg()
        {
            Console.WriteLine("puntenProprammingPrinciples");
            PuntenProprammingPrinciples = Convert.ToInt32(Console.ReadLine());
        }

        private void AskPuntenWeb()
        {
            Console.WriteLine("puntenWebTech");
            PuntenWebTech = Convert.ToInt32(Console.ReadLine());
        }
        
    }

}

