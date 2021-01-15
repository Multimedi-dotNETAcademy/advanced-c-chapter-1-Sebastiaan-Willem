using System;

namespace StudentKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Studentklasse");

            //Methode om student aan te maken via user input
            Student studentx = new Student();
            studentx.VoegStudentToe();
            

            //Methode om student aan te maken
            Student student1 = new Student();

            student1.Leeftijd = 34;
            student1.Naam = "Frank";
            student1.PuntenCommunicatie = 13;
            student1.PuntenWebTech = 15;
            student1.PuntenProprammingPrinciples = 12;
            student1.Klas = Klasgroep.EA2;


            Student student2 = new Student();

            student2.Leeftijd = 28;
            student2.Naam = "Elise";
            student2.PuntenCommunicatie = 13;
            student2.PuntenWebTech = 15;
            student2.PuntenProprammingPrinciples = 12;
            student2.Klas = Klasgroep.EA3;

            //Andere schrijfwijze om student aan te maken
            Student student3 = new Student
            {
                Leeftijd = 21,
                Naam = "Willy",
                PuntenCommunicatie = 2,
                PuntenWebTech = 14,
                PuntenProprammingPrinciples = 15,
                Klas = Klasgroep.EA3

            };

        Student student4 = new Student
        {
            Leeftijd = 58,
            Naam = "Ward",
            PuntenCommunicatie = 3,
            PuntenWebTech = 5,
            PuntenProprammingPrinciples = 9,
            Klas = Klasgroep.EA1
            };

            //aanmaken student via Constructor methode met parameters. (zie klasse Student lijn 40)
            Student student5 = new Student("Sarah", 24, Klasgroep.EA4, 10, 17, 16);

            studentx.Rapport();
            student1.Rapport();
            student2.Rapport();
            student3.Rapport();
            student4.Rapport();
            student5.Rapport();

        }
    }
}
