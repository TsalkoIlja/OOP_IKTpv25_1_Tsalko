using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IKTpv25_1_Tsalko
{
    public abstract class Isik
    {
        private int sünniaasta;

        public string Nimi { get; set; }

        // ⭐ STAATILINE LOENDUR — ühine kõigile isikutele
        public static int InimesteKoguarv = 0;

        public int Sünniaasta
        {
            get => sünniaasta;
            set
            {
                if (value == 0)
                {
                    // 0 = sünniaasta pole teada — see on OK
                    sünniaasta = 0;
                    return;
                }

                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Vigane aasta!");

                sünniaasta = value;
            }
        }


        public int Vanus => sünniaasta == 0 ? 0 : DateTime.Now.Year - sünniaasta;

        public void Tervita()
        {
            if (string.IsNullOrEmpty(Nimi) || sünniaasta == 0)
                Console.WriteLine("Tere! Ma ei tea veel oma nime ega sünniaastat.");
            else
                Console.WriteLine($"Tere! Mina olen {Nimi} ja ma olen {Vanus} aastat vana.");
        }

        // ⭐ KONSTRUKTOR — siia lisame loenduri suurendamise
        public Isik(string nimi, int sünniaasta = 0)
        {
            Nimi = nimi;
            Sünniaasta = sünniaasta;

            // ⭐ IGA UUS ISIK SUURENDAB LOENDURIT
            InimesteKoguarv++;
        }

        public abstract void Kirjelda();
    }

}
