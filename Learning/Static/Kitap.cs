using System;

namespace Static
{
    public class Kitap
    {
        public static void kitap()
        {
            Console.WriteLine("KİTABINIZ");
            Console.ReadLine();
        }
       public static void yazdır(string isim, string yazar, string koku, int sayfa, string konu)
        {
            Console.WriteLine("İsmi: " + isim);
            Console.WriteLine("Yazar: " + yazar);
            Console.WriteLine("Kokusu: " + koku);
            Console.WriteLine("Sayfa Sayısı: " + sayfa);
            Console.WriteLine("Konusu: " + konu);
            Console.ReadLine();
        }
    }
}