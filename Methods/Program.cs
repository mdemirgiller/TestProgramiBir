using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Id = 1;
            urun1.Fiyati = 5;
            urun1.Currency = "TL";

            Urun urun2 = new Urun();
            urun2.Adi = "Kayısı";
            urun2.Id = 2;
            urun2.Fiyati = 10;
            urun2.Currency = "TL";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Id = 3;
            urun3.Fiyati = 7;
            urun3.Currency = "TL";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3};

            //For ile Listelemel için
            //for (int i = 0; i < urunler.Length; i++)
            {
               //Urun urun = urunler[i];
               //Console.WriteLine(urun.Adi);
               //Console.WriteLine(urun.Id);
               //Console.WriteLine(urun.Fiyati);
               //Console.WriteLine(urun.Currency);
               //Console.WriteLine("------------------");

            }
            //MUTLAKA CLASS OLARAK TEK SATIRDA YAZDIRMAYI DENE!!!
            //Console.WriteLine("For Bitti");

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Currency);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("Foreach Bitti");

            Console.WriteLine("-----------Methods----------");
            //yeni bilgi girdiğinde sorun olmaması için Ekle kısmını class olarak eklemek faydalı, yoksa her yeni
            //veriyi class içine eklediğinde, diğer tüm veri barındıran fonksiyonları da değiştirmen gerekir. Bunun
            //adına encapsulation deniyor.

            SepetManager sepetmanager = new SepetManager();
            
            //doğru örnek
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle(urun3);


            //kötü örnek
            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12,100);
            sepetmanager.Ekle2("Elma", "Sarı Elma", 15,10);
            sepetmanager.Ekle2("Kiraz", "Kırmızı Kiraz",10, 20);
    
        }
    }
}
