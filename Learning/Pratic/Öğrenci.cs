using System;

namespace Pratic
{
    public class Öğrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;

        public Öğrenci(int _ogrenciNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulismi)
        {
            ogrenciNo = _ogrenciNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulismi = _okulismi;
        }

        public void ogrencibilgileriGoster()
        {
            Console.WriteLine(" :ÖĞRENCİ BİLGİLERİ: ");
            Console.WriteLine("İsmi: " + isim );
            Console.WriteLine("Soyadı: " + soyisim);
            Console.WriteLine("Numarası: " + ogrenciNo);
            Console.WriteLine("_____________________");
            Console.ReadLine();
        }

        public void ortalamahesapla()
        {
            int sonuc = (((vize1 ) * 20) / 100) + (((vize2 ) * 20) / 100) + ((final * 60) / 100);
            
            Console.WriteLine("ORTALAMANIZ: " + sonuc);
            Console.ReadLine();
        }

        public void okulgetir()
        {
            Console.WriteLine("ÖĞRENCİNİN OKULU " + okulismi);
            Console.ReadLine();
        }
    }
}