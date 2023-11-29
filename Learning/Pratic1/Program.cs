using System;

namespace Pratic1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] sayilar = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Lütfen " + (i+1) + ". Sayıyı Giriniz: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            int sonuc =0;

            foreach (int a in sayilar)
            {
                sonuc += a;
            }
            Console.WriteLine("Girdiğiniz sayıların toplamı: " + sonuc);
            Console.ReadLine();


        }
    }
}