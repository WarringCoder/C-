using System;

namespace Classes
{
    public class Stadyum
    {
        public int Kapasite;
        public int Ortseyirci;
        public string İsim;
        public string Takım;

        public void Açılış()
        {
            Console.WriteLine("Stadyumun Kapıları Açılıyor!");
        }

        public void Güvenlik()
        {
            Console.WriteLine("Güvenlik Görevlileri Yerlerini Aldı....");
        }

        public void Seyirci()
        {
            Console.WriteLine("Seyirciler Kontrollü Bir Şekilde İçeri Alınıyor...");
        }

        public void Takımotobüsleri()
        {
            Console.WriteLine("Takım Otobüsleri Stada Giriş Yaptı");
        }

        public void Isınma()
        {
            Console.WriteLine("Takımlar Sahaya Isınmaya Çıkıyor");
        }
        
        public void Kontrol()
        {
            Console.WriteLine("Maçın Başlamasına Son 15 Dakika...");
            Console.WriteLine("Saha HAZIR!");
            Console.WriteLine("Ses Sistemi HAZIR");
            Console.WriteLine("Hakemler HAZIR");
            Console.WriteLine("Oyuncular HAZIR");
        }

        public void Başlat()
        {
            Console.WriteLine("MAÇ BAŞALDI");
        }
    }
}