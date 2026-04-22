using System;
using System.Collections.Generic;
using System.Text;
namespace OOP_IKTpv25_1_Tsalko
{
    public class Õpetaja : Isik, ITööline, IHindaja
    {
        public string Aine { get; set; }
        public double Baaspalk { get; set; } = 1200;

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;

        // ⭐ ПУСТОЙ КОНСТРУКТОР — старый код работает
        public Õpetaja() : base("Nimetu")
        {

        }

        // ⭐ СТАРЫЙ КОНСТРУКТОР — тоже оставляем
        public Õpetaja(string nimi, int sünniaasta, string aine, double baaspalk)
            : base(nimi, sünniaasta)
        {
            Aine = aine;
            Baaspalk = baaspalk;
        }

        // ⭐ НОВЫЙ КОНСТРУКТОР ПО ЗАДАНИЮ
        public Õpetaja(string nimi, string aine, double baaspalk)
            : base(nimi)
        {
            Aine = aine;
            Baaspalk = baaspalk;
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }

        public virtual double ArvutaPalk()
        {
            return Baaspalk + 300;
        }

        public void Hinda(string hinne)
        {
            Console.WriteLine($"Õpetaja {Nimi} pani hinde: {hinne}");
        }
    }

}


