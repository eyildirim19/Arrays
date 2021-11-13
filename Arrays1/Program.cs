using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler....");

            // değişken sayısı arttıkça yönetilmesi zorlacaştır. Bunun örneği region1de'dir. yeni değişken geldikçe veya değişken silmemiz gerektiğinde koda müdahele etmemiz gerekecektir. bu tür durumlarda yani birde fazla değşken ile çalışmamız gerektiğinde kullanacağımız yöntem dizilerdir...

            // Array (Dizi) =>birden fazla aynı tipte değişkenin veya verinin bir arada tutulmasını sağlayan yapılara denir.. verileriniz bir değşkende tutulup rahatça yönetilebilir... bu sayede kodlarınız daha kısa yazaarsınız..
            // 5 adet değişkenimiz var....
            int s1 = 4, s2 = 5, s3 = 20, s4 = 10, s5 = 1;
            int enb = 0;
            #region Region1 // kodlarınızı bloklamak (gruplamak) için kullanılan yöntemdir....



            // 5 adet değişlen içerisinden en büyüğünü bulup ekrana yazdıralım....

            if (s1 > s2 && s1 > s3 && s1 > s4 && s1 > s5)
            {
                enb = s1; // s1 büyüktür...
            }
            else if (s2 > s1 && s2 > s3 && s2 > s4 && s2 > s5)
            {
                enb = s2; // s2 büyüktür...
            }
            else if (s3 > s1 && s3 > s2 && s3 > s4 && s3 > s5)
            {
                enb = s3; // s2 büyüktür...
            }
            else if (s4 > s1 && s4 > s2 && s4 > s3 && s4 > s5)
            {
                enb = s4; // s2 büyüktür...
            }
            else
            {
                enb = s5;
            }


            #endregion

            // Örnek dizi tanımlaması...
            // <tip>[] diziIsmi = new <tip>[elemanSayisi];
            int[] sayilar = new int[5]; // 5 elemanlı bir dizi
            //diziler birden fazla verinin bellekteki adresini tutan yapılardır. bu yüzden diziler referans type grubuna girerler...
            // dizilerin elemanlarına indexler ile erişiriz...erişmek bir dizi elemanını okumak veya yazmak içindir..c# dilinde index operatörü = []

            sayilar[0] = s1;
            sayilar[1] = s2;
            sayilar[2] = s3;
            sayilar[3] = s4;
            sayilar[4] = s5;


            // dizileri kapalı bir kutu olarak düşünün. kutuyu açmak ve içerideki nesneleri çıkartmak için kutudan tek tek almak gerekir...

            // dizinin 3'ü elemanını ekrana yazdıralım....
            Console.WriteLine($"Dizinin 3. elemanı {sayilar[2]}");
            // dizinin 4'ü elemanını bir değişkene atayalım...
            int değer = sayilar[3];

            // dizileri açmanın yolu döngülerden geçer...döngüler ile dizi içerisindeki elemanlara (for, while, dowhile ve foreach döngüsü ile erişebiliriz...


            // dizinin elemanlarınını tamamını ekrana yazdıralım....
            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[1]);
            Console.WriteLine(sayilar[2]);
            Console.WriteLine(sayilar[3]);
            Console.WriteLine(sayilar[4]);


            Console.WriteLine($"En büyük sayımız = {enb}");

            Console.ReadKey();
        }
    }
}
