using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IKTpv25_1_Tsalko
{
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }

        public double KeskmineHinne { get; set; } // põhitoetus 60€
        public int Puudumised { get; set; }       // kui palju puudumisi
        public bool KasOnSotsTõend { get; set; } = false; // eritoetus 120€
        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;
        public Õppevorm Staatus { get; set; }  //ENUM SIIN

        // ПУСТОЙ КОНСТРУКТОР — чтобы старый код работал
        public Õpilane() : base("Nimetu")
        {

        }

        // ГЛАВНЫЙ КОНСТРУКТОР
        public Õpilane(
            string nimi,
            string kool,
            int klass,
            double keskmineHinne,
            int puudumised,
            bool kasOnSotsToend,
            Õppevorm staatus,
            int sünniaasta
        ) : base(nimi, sünniaasta)
        {
            Kool = kool;
            Klass = klass;
            KeskmineHinne = keskmineHinne;
            Puudumised = puudumised;
            KasOnSotsTõend = kasOnSotsToend;
            Staatus = staatus;
        }

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib koolis {Kool} ja käib {Klass}. klassis. Vorm: {Staatus}");
        }

        public override void Kirjelda()
        {
            Console.WriteLine(
                $"Mina olen õpilane {Nimi}, õpin {Kool} {Klass}. klassis, " +
                $"keskmine hinne: {KeskmineHinne}, puudumisi: {Puudumised}, " +
                $"sotsiaaltoetus: {KasOnSotsTõend}."
            );
        }

        public double ArvutaPalk()
        {
            double põhitoetus = 60 * (KeskmineHinne >= 3.5 ? 1 : 0);
            double eritoetus = 120 * (KasOnSotsTõend ? 1 : 0);
            double puudumisteKaristus = (Puudumised > 20 ? 0 : 1);

            return (põhitoetus + eritoetus) * puudumisteKaristus;
        }

    }
}

