using System;

namespace ArrayList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            System.Collections.ArrayList isimler = new System.Collections.ArrayList();
            isimler.Add("İshak");
            isimler.Add("Furkan");
            isimler.Add("Zeynep");
            isimler.Add("Mehmet");

            isimler.Remove("Mehmet");
        ;

            foreach (string i in isimler)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine(isimler.IndexOf("Furkan"));

            Console.ReadLine();



        }
    }
}