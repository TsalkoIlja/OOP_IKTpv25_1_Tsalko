using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IKTpv25_1_Tsalko
{
    public abstract class Isik
    {
        private int sünniaasta;

        public string Nimi { get; set; }

        public int Sünniaasta
        {
            get { return sünniaasta; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    sünniaasta = value;
                else
                    Console.WriteLine("Vigane sünniaasta!");
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

        // ABSTRACT 
        public abstract void Kirjelda();
    }
}
