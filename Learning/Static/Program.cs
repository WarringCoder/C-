using System;

namespace Static
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           Kitap.kitap();
           Kitap.yazdır("Mecburiyet", "Stefan Zweig", "Fesleğen", 120, "Hikaye" );
           Staticdegiskenkullanımı.sayi = 17;
           Console.WriteLine(Staticdegiskenkullanımı.sayi);

           Staticclass.a = 123;
           Staticclass.yazdır();
        }
    }
}