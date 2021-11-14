using System;

namespace Arrays7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BT AKADEMİ KAYIT SİSTEMİ");

            char durum;
            string[] kayitlar = new string[1];

            do
            {
                Console.WriteLine("Kullanıcı Adı Giriniz");
                string ad = Console.ReadLine();

                kayitlar[kayitlar.Length - 1] = ad;
                Console.WriteLine("Yeni Kayıt Yapmak İstermisiniz ????? Evet için e Hayır için h basın");
                durum = Convert.ToChar(Console.ReadLine().ToLower());

                if (durum == 'e')
                    Array.Resize(ref kayitlar, kayitlar.Length + 1);

            } while (durum == 'e'); // durum true ise demek...

            Console.WriteLine("kayıt yapılan öğrenciler....");
            foreach (var item in kayitlar)
                Console.WriteLine(item);


            Console.ReadKey();
        }
    }
}
