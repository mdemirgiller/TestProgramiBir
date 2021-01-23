using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Ad + "Adlı Müşteri Müşteriler Listesine Eklendi");
        }
        public void Cikar(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "Adlı Müşteri Müşteriler Listesinden Çıkarıldı");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad+"  "+ musteri.Soyad + "  " + musteri.Id);
            }
        }
    }
}
