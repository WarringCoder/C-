using System;

namespace İnheritance
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Python python = new Python();
            python.isim = "Python";
            python.zorlukderecesi = "Zor";
            python.öğrenimsüresi = 50;
            
            python.yazdır();
        }
    }
}