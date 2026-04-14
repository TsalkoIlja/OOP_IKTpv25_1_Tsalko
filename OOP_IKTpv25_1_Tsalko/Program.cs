using System;
using System.Numerics;

namespace OOP_IKTpv25_1_Tsalko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Заменяем Isik → Õpilane
            Isik inimene1 = new Õpilane();
            inimene1.Nimi = "Mati";
            inimene1.Sünniaasta = 2009;
            inimene1.Kirjelda();

            Console.WriteLine();

            // Õpilane
            Õpilane oppilane = new Õpilane();
            oppilane.Nimi = "Mark";
            oppilane.Sünniaasta = 2008;
            oppilane.Kool = "Tallina Tööstushariduskeskus";
            oppilane.Klass = 10;
            oppilane.Kirjelda();
            oppilane.Õpi();

            Console.WriteLine();

            // Õpetaja
            Õpetaja opetaja = new Õpetaja();
            opetaja.Nimi = "Aleksandra";
            opetaja.Sünniaasta = 1965;
            opetaja.Aine = "Bioloogia";
            opetaja.Kirjelda();
            opetaja.Õpeta();

            Console.WriteLine();

            // Direktor
            Direktor direktor = new Direktor();
            direktor.Nimi = "Katrin";
            direktor.Aine = "Matemaatika";
            direktor.Baaspalk = 1500;
            direktor.Lisatasu = 600;

            direktor.Kirjelda();
            Console.WriteLine("Direktori palk kokku: " + direktor.ArvutaPalk() + "€");
        }
    }
}