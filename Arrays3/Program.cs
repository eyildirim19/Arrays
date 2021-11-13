using System;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] dizi1 = new bool[2];
            dizi1[0] = false;
            dizi1[1] = true;

            char[] chars = new char[5];
            chars[0] = 'E';
            chars[1] = 'k';
            chars[2] = 'r';
            chars[3] = 'e';
            chars[4] = 'm';

            string[] mevsimler = new string[4];
            mevsimler[0] = "ilkbahar";
            mevsimler[1] = "yaz";
            mevsimler[2] = "sonbahar";
            mevsimler[3] = "kış";

            int[] sayilar = new int[2];
            sayilar[0] = 1;
            sayilar[1] = 1;

            // foreach döngüsünde item'ın tipi var olarak tanımlayabilirsiniz...Genelde böyle yazılır...

            //foreach yazıp tab tab yaparsanız foreach komutu sizin için otomatik yazılacaktır...
            foreach (var item in dizi1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******************");
            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************");
            foreach (var item in mevsimler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************");
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }


            int[] sayilar2 = new int[3];
            foreach (int item in sayilar2)
            {
                //  item = 3;  //  NOT:FOREACH DÖNGÜSÜNDE DİZİ ELEMANLARININ DEĞERLERİ DEĞİTŞRİLEMEZ... ÇÜNKÜ İTEM DEĞİŞKENİ GEÇİCİ BİR DEĞİŞKENDİR. VEYA FOREACH ITERATION objesidir. iteration => döngünün ileri yönlü gitmesidir...
            }

            Console.ReadKey();

        }
    }
}
