using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_IKTpv25_1_Tsalko
{
    public class Õpilane : Isik
    {
        public string Kool { get; set; }
        public int Klass { get; set; }

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpilane {Nimi} ja käin {Klass}. klassis.");
        }
    }
}
