using System;

namespace EncapsulationProporty
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Takım isim = new Takım();
            isim.TAKIM = "GALATASARAY";
            string isimkullan = isim.TAKIM;
            Console.WriteLine(isimkullan);
        }
    }
}