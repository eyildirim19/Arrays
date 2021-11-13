using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // diziler aynı tipden verilerin bir arada tutulduğu yapılardır... (aynı tip)
            int[] sayilar = new int[3]; // dizilerde eleman sayısı belirtilmek zorundadır...

            // Length özelliği (property) dizinin eleman sayısını verir...
            Console.WriteLine($" Dizinin eleman sayısı {sayilar.Length}");

            sayilar[1] = 1;
            sayilar[0] = 3;
            sayilar[2] = 5;


            string[] isimler = new string[8];
            isimler[2] = "Serhat";
            isimler[7] = "Furkan";
            isimler[0] = "Bahar";
            isimler[1] = "Evren";
            isimler[3] = "Büşra";
            isimler[6] = "Önder";
            isimler[4] = "Suna";
            isimler[5] = "Semiha";

            //isimler[8] = "Ekrem"; bu atama gerçekleşemez çünkü dizinin en büyük indexi elemanısayısı -1 dir

            //foreach döngüsü => (c# diline ait bir döngüdür....) Özel bir döngüdür... foreach döngüsü sadece dizilerde işlem yapmak için kullanılır...foreach döngüsü dizi içerisindeki elemanları ileri yönlü OKUMAK için kullanıılır...
            /*
                foreach(<tip> item in dizi){
                        // dizi okuma işlemleri....
                }
                
            Kural => <tip> dizi tipi iel aynı olmalıdır...
                
            item değişkeni temp (geçici) değer tutmak için kullanılır. in komutu dizi içerisindeki okunacak elemanı item değişkenine set(atamak) eder.in komutu burada hem bir sayaç hemde karar mekanizması görevi görür..

             */

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("**********************");

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim); // ismi ekrana yazdır.. 
            }

            Console.ReadKey();
        }
    }
}
