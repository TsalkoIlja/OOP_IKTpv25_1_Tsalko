using System;
using System.Collections.Generic;

namespace OOP_IKTpv25_1_Tsalko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== KOOLIHALDUS ALGUS ===");
                Koolihaldus kool = new Koolihaldus();

                // --- Õpetaja ---
                Õpetaja op = new Õpetaja("Mati", "Programmeerimine", 1500);

                // --- Õpilane ---
                Õpilane opilane1 = new Õpilane
                {
                    Nimi = "Mari",
                    Sünniaasta = 2007,
                    Klass = 10,
                    Staatus = Õppevorm.Päevane
                };

                kool.LisaInimene(op);
                kool.LisaInimene(opilane1);

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
                kool.LisaInimene(oppilane);

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
                kool.LisaInimene(opetaja);

                opetaja.Kirjelda();
                Console.WriteLine("Õpetaja palk: " + opetaja.ArvutaPalk() + "€\n");

                opetaja.Hinda("5");

                // --- Direktor ---
                Direktor direktor = new Direktor("Ilja", 1985, "Paleontoloogia", 1500, 600);
                kool.LisaInimene(direktor);

                direktor.Kirjelda();
                Console.WriteLine("Direktori palk kokku: " + direktor.ArvutaPalk() + "€");

                // --- Polümorfism ---
                List<ITööline> palgasaajad = new List<ITööline>
                {
                    oppilane,
                    opetaja,
                    direktor
                };

                // --- Õpilased ---
                Õpilane mati = new Õpilane
                {
                    Nimi = "Mati",
                    Sünniaasta = 2006,
                    Kool = "TTHK",
                    Klass = 9,
                    KeskmineHinne = 4.0,
                    Puudumised = 3,
                    KasOnSotsTõend = false,
                    Staatus = Õppevorm.Kaugõpe
                };
                kool.LisaInimene(mati);

                Õpilane kadi = new Õpilane
                {
                    Nimi = "Kadi",
                    Sünniaasta = 2005,
                    Kool = "TTHK",
                    Klass = 11,
                    KeskmineHinne = 4.5,
                    Puudumised = 1,
                    KasOnSotsTõend = true,
                    Staatus = Õppevorm.Päevane
                };
                kool.LisaInimene(kadi);

                Õpilane jyri = new Õpilane
                {
                    Nimi = "Jüri",
                    Sünniaasta = 2004,
                    Kool = "TTHK",
                    Klass = 12,
                    KeskmineHinne = 3.8,
                    Puudumised = 10,
                    KasOnSotsTõend = false,
                    Staatus = Õppevorm.Ekstern
                };
                kool.LisaInimene(jyri);

                // --- Õpetajad ---
                Õpetaja anna = new Õpetaja
                {
                    Nimi = "Anna",
                    Sünniaasta = 1988,
                    Aine = "Python",
                    Baaspalk = 1300
                };
                kool.LisaInimene(anna);

                Õpetaja peeter = new Õpetaja
                {
                    Nimi = "Peeter",
                    Sünniaasta = 1982,
                    Aine = "C#",
                    Baaspalk = 1400
                };
                kool.LisaInimene(peeter);

                palgasaajad.AddRange(new ITööline[] { mati, kadi, jyri, anna, peeter });

                // --- Random õpilased ---
                Random rnd = new Random();
                string[] nimed = { "Maria", "Kati", "Juhan", "Anna", "Siim" };

                for (int i = 0; i < 10; i++)
                {
                    Õpilane õpilane = new Õpilane
                    {
                        Nimi = nimed[rnd.Next(nimed.Length)],
                        Sünniaasta = rnd.Next(2003, 2017),
                        Klass = rnd.Next(1, 13),
                        Kool = "TTHK",
                        KeskmineHinne = Math.Round(rnd.NextDouble() * 5, 2),
                        Puudumised = rnd.Next(0, 50),
                        KasOnSotsTõend = rnd.Next(0, 2) == 1,
                        Staatus = (Õppevorm)rnd.Next(0, 4)
                    };

                    palgasaajad.Add(õpilane);
                    kool.LisaInimene(õpilane);
                }

                // --- Üliõpilane ---
                Üliõpilane ylikool = new Üliõpilane
                {
                    Nimi = "Karl",
                    Sünniaasta = 2003,
                    Kool = "TalTech",
                    Klass = 2,
                    Eriala = "IT-süsteemid",
                    KeskmineHinne = 4.7,
                    Puudumised = 1,
                    KasOnSotsTõend = false,
                    Staatus = Õppevorm.Päevane
                };

                kool.LisaInimene(ylikool);
                palgasaajad.Add(ylikool);

                // --- Õpilane KONСТРУКТОРИГА ---
                Õpilane testKonstruktor = new Õpilane(
                    "Testi-Õpilane",
                    "TTHK",
                    7,
                    4.1,
                    2,
                    false,
                    Õppevorm.Päevane,
                    2010
                );

                kool.LisaInimene(testKonstruktor);
                palgasaajad.Add(testKonstruktor);

                // --- Õpetaja KONСТРУКТОРИГА ---
                Õpetaja testOpetaja = new Õpetaja(
                    "Test-Õpetaja",
                    1980,
                    "Matemaatika",
                    1600
                );

                kool.LisaInimene(testOpetaja);
                palgasaajad.Add(testOpetaja);

                Console.WriteLine("\n=== KÕIK INIMESED KOOLIS ===");

                List<Isik> grupp = new List<Isik>
                {
                    new Õpilane { Nimi = "Test1", Sünniaasta = 2005, Klass = 9 },
                    new Õpetaja { Nimi = "Test2", Sünniaasta = 1980, Aine = "Keemia", Baaspalk = 1200 }
                };
                kool.LisaInimene(grupp);

                Isik[] massiiv = {
                    new Õpilane { Nimi = "Mass1", Sünniaasta = 2006, Klass = 8 },
                    new Õpetaja { Nimi = "Mass2", Sünniaasta = 1975, Aine = "Füüsika", Baaspalk = 1400 }
                };
                kool.LisaInimene(massiiv);

                kool.KuvaKõik();

                Console.WriteLine("\n--- Väljamaksed ---");
                foreach (ITööline isik in palgasaajad)
                {
                    string tüüp = isik.VäljamakseTüüp.ToString();
                    Console.WriteLine($" {tüüp} summa: {isik.ArvutaPalk()} eurot {((Isik)isik).Nimi}le");
                }

                Console.WriteLine("\n=== OTSING ===");
                kool.OtsiNimeJärgi("Ka");
                kool.Otsi(2008);
                kool.Otsi(2010);

                Console.WriteLine($"\nKoolis on registreeritud kokku {Isik.InimesteKoguarv} isikut.");
                kool.SalvestaFaili("kool.txt");
                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Viga andmete sisestamisel: " + ex.Message);
            }
        }
    }
}



