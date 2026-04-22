using OOP_IKTpv25_1_Tsalko;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Direktor : Õpetaja
{
    public double Lisatasu { get; set; }

    // ⭐ KONSTRUKTOR
    public Direktor(string nimi, int sünniaasta, string aine, double baaspalk, double lisatasu)
        : base(nimi, sünniaasta, aine, baaspalk)
    {
        Lisatasu = lisatasu;
    }

    public override double ArvutaPalk()
    {
        return base.ArvutaPalk() + Lisatasu;
    }

    public override void Kirjelda()
    {
        Console.WriteLine($"Mina olen direktor {Nimi}. Minu palk on {ArvutaPalk()}€.");
    }
}
