using System;

namespace Encapsulation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Futbolcu futbolcu1 = new Futbolcu();
            futbolcu1.setFutbolcu("Kerem Aktürkoğlu");
            string  gelenFutbolcu = futbolcu1.getFutbolcu();

            for (int a=1; a<=3; a++)
            {
                Console.WriteLine("Goooooolll " + gelenFutbolcu + " " + a + ". Golünü atıyor!");
            }
        }
    }
}