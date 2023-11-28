using System;

namespace Classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Stadyum stadyum1 = new Stadyum();

            stadyum1.İsim = "INTERSTELLAR";
            stadyum1.Kapasite = 100000;
            stadyum1.Ortseyirci = 980000;
            stadyum1.Takım = "WarringCoders";
            Gazeteci gazeteci1 = new Gazeteci(1000, 56);
            
            Console.WriteLine("***********************");
            Console.WriteLine("Stadyum: " + stadyum1.İsim);
            Console.WriteLine("Takım: " + stadyum1.Takım);
            Console.WriteLine("Kapasite: " + stadyum1.Kapasite);
            Console.WriteLine("Ortalama Seyirci: " + stadyum1.Ortseyirci);
            Console.WriteLine(gazeteci1.kaçfarklıül + " Farklı Ülkeden " + gazeteci1.gazetecisayısı + " Gazeteci");
            Console.WriteLine("***********************");
            
            stadyum1.Açılış();
            Console.WriteLine("***********");
            stadyum1.Güvenlik();
            Console.WriteLine("***********");
            stadyum1.Seyirci();
            Console.WriteLine("***********");
            stadyum1.Takımotobüsleri();
            Console.WriteLine("***********");
            stadyum1.Isınma();
            Console.WriteLine("***********");
            stadyum1.Kontrol();
            Console.WriteLine("***********");
            stadyum1.Başlat();
            Console.WriteLine("***********");

            Console.ReadLine();

        }
    }
}