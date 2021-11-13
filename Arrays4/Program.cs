using System;

namespace Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            // eğer dizi elemanlarınız sabitse, dizinin başlangıç aşamısnda değer ataması yapabilirsiniz...
            // sabit dizi

            string[] mevsimler = { "İlkbahar", "Yaz", "Sonbahar", "kış" };
            mevsimler[3] = "Kış";
            char[] chars = { 'E', 'k', 'r', 'e', 'm' };
            bool[] bools = { true, false };

            // yukarıdaki tanımlamanın adı object initializer diye geçer...
            // ekrana mevsimleri tek tek yazdıralım..
            // Not : eğer blok içerisinde tek satır işlem yapacaksınız scope açıp kapamanıza gerek yoktur...
            foreach (var item in mevsimler)
                Console.Write($"{item}  ");

            Console.WriteLine("********");


            // ekrana mevsimleri tersten yazdıralım...
            for (int i = mevsimler.Length - 1; i >= 0; i--)
                Console.Write($"{mevsimler[i]}  ");

            Console.ReadKey();
        }
    }
}