using System;

namespace İnheritance
{
    public class Yazılımdili 
    {
        public string isim;
        internal  string zorlukderecesi;
        public int öğrenimsüresi;

        public  void yazdır()
        {
            Console.WriteLine(isim);
            Console.WriteLine(zorlukderecesi);
            Console.WriteLine(öğrenimsüresi);
        }
    }
}