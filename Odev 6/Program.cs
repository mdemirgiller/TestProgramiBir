using System;

namespace Odev_6
{
    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunKodu { get; set; }
        public string UrunRengi { get; set; }
        public int UrunFiyati { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Elma";
            urun1.UrunKodu = 1 ;
            urun1.UrunRengi = "Kırmızı";
            urun1.UrunFiyati = 5 ;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Armut";
            urun2.UrunKodu = 2 ;
            urun2.UrunRengi = "Yeşil";
            urun2.UrunFiyati = 7 ;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Kayısı";
            urun3.UrunKodu = 3 ;
            urun3.UrunRengi = "Sarı";
            urun3.UrunFiyati = 10 ;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(Urun[i]);
            }
                Console.WriteLine("For Bitti");
        }
    }

}   

    