using System;
using System.IO;
namespace OOP_IKTpv25_1_Tsalko
{
    public class Üliõpilane : Õpilane
    {
        public string Eriala { get; set; }

        public override void Kirjelda()
        {
            Console.WriteLine(
                $"Mina olen üliõpilane {Nimi}, õpin erialal: {Eriala}, " +
                $"{Klass}. kursus, õppevorm: {Staatus}."
            );
        }
    }
}

