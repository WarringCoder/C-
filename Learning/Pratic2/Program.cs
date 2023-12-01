using System;

namespace Pratic2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 12, 0, -12, 13, 67, 12345, -2, -54987, 56, -124 };
            for (int i=0; i<= numbers.Length; i++)
            {
                if (numbers[i] > 0  )
                {
                    Console.WriteLine("Sayı: " + numbers[i] + " Pozitif");
              
                }
                else if (numbers[i] < 0)
                {
                    Console.WriteLine("Sayı: " + numbers[i] + " Negatif");
                   
                }
                else
                {
                    Console.WriteLine("Sayı: " + numbers[i] + " Ne Pozitif Ne Negatif");
               
                }
                
            }
            Console.ReadLine();
           
        }
    }
}