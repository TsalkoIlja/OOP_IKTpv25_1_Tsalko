using System;
using System.Collections.Generic;
using System.IO;

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

        // --- ÜLELAADIMINE: lisamine massiiviga ---
        public void LisaInimene(Isik[] uuedInimesed)
        {
            inimesed.AddRange(uuedInimesed);
        }

        // --- ÜLELAADIMINE: lisamine List<Isik> abil ---
        public void LisaInimene(List<Isik> uuedInimesed)
        {
            inimesed.AddRange(uuedInimesed);
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


        public void OtsiNimeJärgi(string otsitavNimi)
        {
            Console.WriteLine($"\n--- Otsingu tulemused: \"{otsitavNimi}\" ---");

            bool leitud = false;

            foreach (Isik inimene in inimesed)
            {
                if (inimene.Nimi.Contains(otsitavNimi, StringComparison.OrdinalIgnoreCase))
                {
                    inimene.Kirjelda();
                    leitud = true;
                }
            }

            if (!leitud)
            {
                Console.WriteLine("Midagi ei leitud.");
            }
        }
        // --- ÜLELAADIMINE: otsing sünniaasta järgi ---
        public void Otsi(int sünniaasta)
        {
            Console.WriteLine($"\n--- Otsingu tulemused sünniaasta järgi: {sünniaasta} ---");

            bool leitud = false;

            foreach (Isik inimene in inimesed)
            {
                if (inimene.Sünniaasta == sünniaasta)
                {
                    inimene.Kirjelda();
                    leitud = true;
                }
            }

            if (!leitud)
            {
                Console.WriteLine("Midagi ei leitud.");
            }
        }
        public void SalvestaFaili(string failinimi)
        {
            using (StreamWriter writer = new StreamWriter(failinimi))
            {
                foreach (Isik inimene in inimesed)
                {
                    // Получаем строку описания
                    // Kirjelda() выводит в консоль, поэтому мы сами формируем строку

                    string rida = inimene switch
                    {
                        Direktor d => $"Direktor: {d.Nimi}, {d.Sünniaasta}, aine: {d.Aine}, palk: {d.Baaspalk}, lisatasu: {d.Lisatasu}",
                        Üliõpilane y => $"Üliõpilane: {y.Nimi}, {y.Sünniaasta}, {y.Kool}, kursus: {y.Klass}, hinne: {y.KeskmineHinne}",
                        Õpetaja t => $"Õpetaja: {t.Nimi}, {t.Sünniaasta}, aine: {t.Aine}, palk: {t.Baaspalk}",
                        Õpilane o => $"Õpilane: {o.Nimi}, {o.Sünniaasta}, {o.Kool}, klass: {o.Klass}, hinne: {o.KeskmineHinne}",
                        _ => $"Isik: {inimene.Nimi}, {inimene.Sünniaasta}"
                    };


                    writer.WriteLine(rida);
                }
            }

            Console.WriteLine($"Fail '{failinimi}' on salvestatud.");
        }


    }
}

