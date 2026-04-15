using System;
using System.Collections.Generic;

namespace OOP_IKTpv25_1_Tsalko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== KOOLIHALDUS ALGUS ===");
            // --- Koolihaldus süsteem ---
            Koolihaldus kool = new Koolihaldus();

            // создаём учителя
            Õpetaja op = new Õpetaja
            {
                Nimi = "Mati",
                Aine = "Programmeerimine",
                Baaspalk = 1500
            };

            // создаём ученика
            Õpilane opilane1 = new Õpilane
            {
                Nimi = "Mari",
                Klass = 10,
                Staatus = Õppevorm.Päevane
            };

            // добавляем в систему
            kool.LisaInimene(op);
            kool.LisaInimene(opilane1);

            // выводим всех
            kool.KuvaKõik();

            Console.WriteLine("=== KOOLIHALDUS LÕPP ===\n");


            // --- Õpilane ---
            Õpilane oppilane = new Õpilane
            {
                Nimi = "Mark",
                Sünniaasta = 2008,
                Kool = "Tallinna Tööstushariduskeskus",
                Klass = 10,
                KeskmineHinne = 4.2,
                Puudumised = 5,
                KasOnSotsTõend = true,
                Staatus = Õppevorm.Päevane
            };

            oppilane.Kirjelda();
            Console.WriteLine("Stipendium: " + oppilane.ArvutaPalk() + "€\n");

            // --- Õpetaja ---
            Õpetaja opetaja = new Õpetaja
            {
                Nimi = "Aleksandra",
                Sünniaasta = 1965,
                Aine = "Bioloogia",
                Baaspalk = 1200
            };

            opetaja.Kirjelda();
            Console.WriteLine("Õpetaja palk: " + opetaja.ArvutaPalk() + "€\n");

            // --- Direktor ---
            Direktor direktor = new Direktor
            {
                Nimi = "Katrin",
                Sünniaasta = 1975,
                Aine = "Matemaatika",
                Baaspalk = 1500,
                Lisatasu = 600
            };

            direktor.Kirjelda();
            Console.WriteLine("Direktori palk kokku: " + direktor.ArvutaPalk() + "€");

            // --- Polümorfism: ühine nimekiri ---
            List<ITööline> palgasaajad = new List<ITööline>
            {
                oppilane,
                opetaja,
                direktor
            };

            // --- Õpilased ja õpetajad ---
            Õpilane mati = new Õpilane
            {
                Nimi = "Mati",
                Kool = "TTHK",
                Klass = 9,
                KeskmineHinne = 4.0,
                Puudumised = 3,
                KasOnSotsTõend = false,
                Staatus = Õppevorm.Kaugõpe
            };

            Õpilane kadi = new Õpilane
            {
                Nimi = "Kadi",
                Kool = "TTHK",
                Klass = 11,
                KeskmineHinne = 4.5,
                Puudumised = 1,
                KasOnSotsTõend = true,
                Staatus = Õppevorm.Päevane
            };

            Õpilane jyri = new Õpilane
            {
                Nimi = "Jüri",
                Kool = "TTHK",
                Klass = 12,
                KeskmineHinne = 3.8,
                Puudumised = 10,
                KasOnSotsTõend = false,
                Staatus = Õppevorm.Ekstern
            };

            Õpetaja anna = new Õpetaja
            {
                Nimi = "Anna",
                Aine = "Python",
                Baaspalk = 1300
            };

            Õpetaja peeter = new Õpetaja
            {
                Nimi = "Peeter",
                Aine = "C#",
                Baaspalk = 1400
            };

            palgasaajad.AddRange(new ITööline[] { mati, kadi, jyri, anna, peeter });

            // --- Random õpilased ---
            Random rnd = new Random();
            string[] nimed = { "Maria", "Kati", "Juhan", "Anna", "Siim" };

            for (int i = 0; i < 10; i++)
            {
                Õpilane õpilane = new Õpilane
                {
                    Nimi = nimed[rnd.Next(nimed.Length)],
                    Klass = rnd.Next(1, 13),
                    Kool = "TTHK",
                    KeskmineHinne = Math.Round(rnd.NextDouble() * 5, 2),
                    Puudumised = rnd.Next(0, 50),
                    KasOnSotsTõend = rnd.Next(0, 2) == 1,
                    Staatus = (Õppevorm)rnd.Next(0, 4) // random õppevorm
                };

                palgasaajad.Add(õpilane);
            }

            // --- Väljamaksed ---
            Console.WriteLine("\n--- Väljamaksed ---");

            foreach (ITööline isik in palgasaajad)
            {
                string tüüp = isik.VäljamakseTüüp.ToString();

                Console.WriteLine($" {tüüp} summa: {isik.ArvutaPalk()} eurot {((Isik)isik).Nimi}le");
            }

            Console.ReadLine();
        }
    }
}


