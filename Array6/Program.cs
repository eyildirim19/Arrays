using System;

namespace Array6
{
    class Program
    {
        static void Main(string[] args)
        {
            // indexof metodu => dizide arama yapar. Aranan eleman dizide varsa indexini döner..aranan eleman dizide yoksa -1 döner...

            // n adet benzersiz sayı istenecek...
            int n;
            Console.WriteLine("Kaç adet sayı gireceksiniz.");
            n = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[n];

            // sayıları alıyoruz
            #region for döngüsü ile
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} . sayıyı giriniz");

            //    int girilenSayi = Convert.ToInt32(Console.ReadLine());

            //    int indexVarmi = Array.IndexOf(sayilar, girilenSayi);
            //    if (indexVarmi == -1)
            //        sayilar[i] = girilenSayi;
            //    else
            //        i--;
            //}
            #endregion

            int syc = 0;
            while (syc < sayilar.Length)
            {
                Console.WriteLine($"{syc + 1} . sayıyı giriniz");
                int girilenSayi = Convert.ToInt32(Console.ReadLine());
                if (Array.IndexOf(sayilar, girilenSayi) == -1)
                    sayilar[syc++] = girilenSayi;
            }

            Console.WriteLine("Girilen sayılar....");
            Array.Sort(sayilar);
            // alınan sayıları göster...
            foreach (var item in sayilar)
                Console.WriteLine(item);

            Console.WriteLine("****************************************");

            Console.WriteLine("Kaç Adet isim girilecek");
            n = Convert.ToInt32(Console.ReadLine());
            string[] isimler = new string[n];
            int i = 0;
            for (; i < isimler.Length;) // ; başlangıç değerinin bittiğin, diğer ; koşulun bittğini söyler...
            {
                Console.WriteLine($"{i + 1}. ismi giriniz");
                string ad = Console.ReadLine();
                if (Array.IndexOf(isimler, ad) == -1)
                    isimler[i++] = ad;
            }

            foreach (var item in isimler)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
