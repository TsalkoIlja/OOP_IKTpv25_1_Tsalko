using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IKTpv25_1_Tsalko
{
    public class Õpetaja : Isik
    {
        public string Aine { get; set; }

        public double Baaspalk { get; set; } = 1200;

        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }

        public virtual double ArvutaPalk()
        {
            return Baaspalk;
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetан: {Aine}.");
        }
    }
}
