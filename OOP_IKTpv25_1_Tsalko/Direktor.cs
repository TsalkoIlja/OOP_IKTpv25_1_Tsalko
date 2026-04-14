using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IKTpv25_1_Tsalko
{
    public class Direktor : Õpetaja
    {
        public double Lisatasu { get; set; }

        public override double ArvutaPalk()
        {
            return base.ArvutaPalk() + Lisatasu;
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen direktor {Nimi}. Minu palk on {ArvutaPalk()}€.");
        }
    }
}
