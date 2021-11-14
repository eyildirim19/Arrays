﻿using System;

namespace Arrays9Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç öğrenci bilgisi girilecek...");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] ogrenciler = new string[n]; // öğrenci isimleri....
            float[] ortalamalar = new float[n];

            for (int i = 0; i < n; i++)
            {
                int sira = i + 1;
                Console.WriteLine($"{sira} öğrencinin adı");
                ogrenciler[i] = Console.ReadLine();

                Console.WriteLine($"{sira} öğrencinin vize notu");
                float vize = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"{sira} öğrencinin final notu");
                float final = Convert.ToSingle(Console.ReadLine());

                ortalamalar[i] = (vize * 0.4f) + (final * 0.6f);
            }


            float genelToplam = 0;
            foreach (var item in ortalamalar)
                genelToplam += item;

            float genelOrtalama = genelToplam / n;

            string[] kalanlar = new string[0];
            string[] gecenler = new string[0];



            for (int i = 0; i < ortalamalar.Length; i++)
            {
                /*******/
                // kalan ve geçen öğrencileri ilgili diziye ekleyiniz.....
                /******/
            }



            foreach (var item in kalanlar)
                Console.WriteLine(item);  // Ekrem - 20

            Console.WriteLine("*********************");

            foreach (var item in gecenler)
                Console.WriteLine(item); // Furkan - 66

        }
    }
}
