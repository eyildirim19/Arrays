using System;

namespace Arrays8
{
    class Program
    {
        static void Main(string[] args)
        {
            // isim giriniz...
            // hangi günler müsaitsiniz...
            // müsaitlik saatlerinizi belirtiniz...

            string[] gunler = new string[1];
            char durum;
            do
            {
                Console.WriteLine("Gün giriniz");
                string gun = Console.ReadLine();

                if (Array.IndexOf(gunler, gun) == -1)
                    gunler[gunler.Length - 1] = gun;
                else
                    Console.WriteLine("Daha önce eklediniz...");

                Console.WriteLine("Başka gün girmek istermisiniz?? e/h");
                durum = Convert.ToChar(Console.ReadLine());

                if (durum == 'e')
                    Array.Resize(ref gunler, gunler.Length + 1);

            } while (durum == 'e');

            Console.WriteLine("Sizin için gün seçmemi istermisiniz??? e/h");
            char cevap = Convert.ToChar(Console.ReadLine());
            if (cevap == 'e')
            {
                Random rnd = new Random(); // Random sınıf rasgele sayı üretmek için kulanılan sınıftır..
                //rnd.Next(); 2 milyara kadar sayı üretir...
                int sansliIndex = rnd.Next(gunler.Length - 1);
                Console.WriteLine($"Dersi yapacağımız gün = {gunler[sansliIndex]}");
            }

            Console.ReadKey();
        }
    }
}
