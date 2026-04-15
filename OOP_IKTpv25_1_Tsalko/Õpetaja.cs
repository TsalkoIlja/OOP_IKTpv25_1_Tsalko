using System;
using System.Collections.Generic;
using System.Text;


namespace OOP_IKTpv25_1_Tsalko
{
    public class Õpetaja : Isik, ITööline
    {
        public string Aine { get; set; }
        public double Baaspalk { get; set; } = 1200;

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }

        // Правильная реализация: один метод, одна логика
        public virtual double ArvutaPalk()
        {
            return Baaspalk + 300; // надбавка учителю
        }
    }
}
