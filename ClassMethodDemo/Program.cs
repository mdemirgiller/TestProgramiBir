using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Mehmet";
            musteri1.Soyad = "Demirgiller";
            musteri1.Id = 12345;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Beste";
            musteri2.Soyad = "Demirgiller";
            musteri2.Id = 123456;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Benek";
            musteri3.Soyad = "Demirgiller";
            musteri3.Id = 12345657;

            Musteri[] MusteriList = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);
            Console.WriteLine("Müşteri Ekleme Tamamlandı");

            musterimanager.Cikar(musteri2);
            Console.WriteLine("Müşteri başarıyla silindi");

            musterimanager.Listele(MusteriList);
            Console.WriteLine("Müşteriler Listelendi");


        }
    }
}
