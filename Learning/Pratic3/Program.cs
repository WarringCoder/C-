using System;

namespace Pratic3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int Kac_Saat_Calisma= 0;
            string Zihin_Kontrol;
            string Atomik_Aliskanliklar;
            string Esneme_Spor;
            
            Console.WriteLine("1-) Lütfen Günde Kaç Saat Çalışdığınızı Giriniz: ");
            Kac_Saat_Calisma += int.Parse(Console.ReadLine());
            Console.WriteLine("2-) Lütfen Her Gün Zihin Kontrol çalışmalarını yapıp yapmadığınızı belirtiniz (YES / NO): ");
            Zihin_Kontrol = Console.ReadLine();
            Console.WriteLine("3-) Lütfen Her Gün Atomik Alışkanlıklarınızı yapıp yapmadığınızı belirtiniz (YES / NO): ");
            Atomik_Aliskanliklar = Console.ReadLine();
            Console.WriteLine("4-) Lütfen Her Gün Esneme / Spor yapıp yapmadığınızı belirtiniz (YES / NO): ");
            Esneme_Spor = Console.ReadLine();

            if (Kac_Saat_Calisma > 7)
            {
                if (Zihin_Kontrol == "yes")
                {
                    if (Atomik_Aliskanliklar == "yes")
                    {
                        if (Esneme_Spor == "yes")
                        {
                            Console.WriteLine("TEBRİKLER :) Hergün Böyle Çalışmaya devam ederseniz 6 aya kalmaz YAZILIMCI olarak MÜKEMMEL bir İŞE girebilirsiniz :) ");   
                        }
                        
                    }
                }
                
            }
            
            
            

        }
    }
}