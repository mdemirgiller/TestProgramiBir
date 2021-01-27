using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic yapı örneği
            //MyList.cs'de yaptığımız T tanımı nedeniyle, burada hangi tip belirtirsek <> içinde, o tipten veri ekleyebiliriz Add Methodu ile
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Mehmet");

            Console.WriteLine(isimler.Length);

            isimler.Add("Osman");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
 
        }
    }
}
