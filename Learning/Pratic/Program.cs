using System;

namespace Pratic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Öğrenci öğrenci1 = new Öğrenci(225036027, "Muhammed İshak" ,"Eren", 100, 100, 100, "Konya Teknik Üniversitesi" );
            Console.WriteLine("Hoşgeldiniz :) Devam etmek için ENTER tuşuna basınız");
            Console.ReadLine();
            Console.WriteLine(" :YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ: ");
            Console.WriteLine("1-) Öğrenci Bilgilerini Göster");
            Console.WriteLine("2-) Öğrenci Ortalaması Göster");
            Console.WriteLine("3-) Öğrencinin Okulunu Göster");
            Console.WriteLine("4-) Çıkış Yap");
            Console.WriteLine("_________________________");
            string secim = Console.ReadLine();
            Console.ReadLine();
            

            

            if (secim == "1")
            {
                öğrenci1.ogrencibilgileriGoster();
            }
            else if (secim == "2")
            {
                öğrenci1.ortalamahesapla();
            }
            else if (secim =="3")
            {
                öğrenci1.okulgetir();
            }
            else if (secim == "4")
            {
                Console.WriteLine("Güle Güle Efendim :)");
            }
        }
    }
}