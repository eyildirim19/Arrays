using System;


namespace Arrays5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[] sayilar = { 3, 4, 6, 10, 11, 100, 200, 201 };

            int[] sirasizer = { 4, 1, 10, 11, 20, 15, 3 };
            // sıralama yapalım...diziyi küçükten büyüğe sıralayalım....

            // https://www.youtube.com/watch?v=lyZQPjUT5B4
            // sıralama algoritmaları nelerdir ?, sirasizer disizini bu algoritmala ile sıralanız....


            // C# dilinde diziler üzerinde işlem yapabilmek için (sıralama,search vb...) Array static sınıfı kullanılır..

            // dizisi sıralama...
            Array.Sort(sirasizer); // siraser dizisini sırala... (artan a-z)
            foreach (var item in sirasizer)
                Console.Write($"{item}  ");

            // diziyi tesrten sıralama
            Array.Reverse(sirasizer); // reverse diziyi test çevirir...eğer ters çevirmeden önce sort ile sıralarssan büküyten küçüğe ters çevirir...
            foreach (var item in sirasizer) // (azalan z-a)
                Console.Write($"{item}  ");


            // dizide arama işlemi yapar. aranan elemen dizide varsa indexini yoksa -1 döner...
            int index = Array.IndexOf(sirasizer, 20);
            int index2 = Array.IndexOf(sirasizer, 100);

            string[] tmp;
            string[] str = { "A", "B", "C" };
            tmp = str;

            str = new string[2]; // 2 elemanlı bir dizi.... new komutu bellekte yeni bir alan açar..
            str = new string[2]; // 2 elemanlı bir dizi.... bellekte yeni bir alan açtık..
            str = new string[22];// 22 elemanlı bir dizi.... belkte yeni bir alan açtık...



            int n = 3;
            n++;
            int[] sayis = new int[n]; // uzunluk 4
            sayis[0] = 1;
            sayis[1] = 2;
            sayis[2] = 3;
            sayis[3] = 4;

            //Array.Resize => diziyi resize etmek için kullanılır....
            sayis = new int[5]; // new komutu => instance (örnek) alma işlemidir. bellekte yeni bir alan açar...
            sayis[4] = 5;

            int[] sayisss = new int[3];
            sayisss[0] = 3;
            sayisss[1] = 5;
            sayisss[2] = 7;

            Array.Resize(ref sayisss, 4); // ref => referans anlamına gelir... sayiss dizisinin uzunluğunu arttırdık..
            sayisss[3] = 10;

            Array.Resize(ref sayisss, 2); // azalttık..
            Array.Resize(ref sayisss, 4);




            Console.ReadKey();
        }
    }
}
