using System;

namespace ArrayOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BT Akademi Öğrenci Kayıt Sistemi");

            Console.WriteLine("Kaç öğrenci kayıt oldu???");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] ogrenciler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1 } öğrencinin adı");
                string ogrenci = Console.ReadLine();

                ogrenciler[i] = ogrenci;
            }

            ///öğrenci bilgilerini kaydettik... şimdi gösterlim...
            foreach (var item in ogrenciler)
            {
                Console.Write($"{item}  ");
            }

            Console.ReadKey();
        }
    }
}
