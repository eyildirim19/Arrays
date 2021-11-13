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

            Console.ReadKey();
        }
    }
}
