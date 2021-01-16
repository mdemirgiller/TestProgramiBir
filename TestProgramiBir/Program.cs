using System;

namespace TestProgramiBir
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int kisiSayisi = 1000;
            double faizOrani = 1.45;
            bool girisYapildiMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            if (girisYapildiMi==true)
            {
                Console.WriteLine("Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
