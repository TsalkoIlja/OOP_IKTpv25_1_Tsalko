using System;

namespace OOP_IKTpv25_1_Tsalko
{
    public class Kursus
    {
        public string Nimi { get; set; }
        public Õpetaja VastutavÕpetaja { get; set; }

        public void KuvaInfo()
        {
            Console.WriteLine($"Kursus: {Nimi}, vastutav õpetaja: {VastutavÕpetaja.Nimi}");
        }
    }
}

