using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {

        public void Ekle(Urun urun) 
        {
            Console.WriteLine(urun.Adi + "  Sepete Eklendi");
        }

        public void Ekle2(string urunAdi,string aciklama, double fiyat, int stokAdet) 
        {
            Console.WriteLine("Tebrikler Sepete Eklendi:" + urunAdi);
        }

         
    }
}
