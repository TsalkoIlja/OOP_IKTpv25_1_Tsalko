using System;
using System.Collections.Generic;

namespace OOP_IKTpv25_1_Tsalko
{
    public class Koolihaldus
    {
        // Приватный список людей
        private List<Isik> inimesed = new List<Isik>();

        // Добавление человека
        public void LisaInimene(Isik isik)
        {
            inimesed.Add(isik);
        }

        // Показать всех людей
        public void KuvaKõik()
        {
            Console.WriteLine("\n--- KOOLI NIMEKIRI ---");

            foreach (var isik in inimesed)
            {
                // Полиморфизм: вызывается правильный Kirjelda()
                isik.Kirjelda();
            }
        }
    }
}

