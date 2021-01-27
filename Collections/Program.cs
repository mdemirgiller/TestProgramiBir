using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Mehmet", "Murat", "Kerem", "Halil"};

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////bir isim eklemek zorunda olduğum zaman, yukarıda array'e isim ekleyip ek bir cw yapmazsam yazmaz.
            ////ek cw ekleyip, listeye eklemezsem de yazmaz.
            ////bunun için çözüm olarak aşağıdaki gibi yaparsak, yeni bir 5 öğeli bir isimler string'i oluşturup, 5.karakterine ilker yazar
            ////ama diğer öğeleri kaybolur ve göremeyiz.
            ////Bu nedenle 0.öğeyi yazdırmak istediğimzde yazamaz.

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //Bunun doğru yöntemi - Yeni isim eklemek ve listelemek için;

            //açılan ampülden collections'u ekleyerek tepeye system.collections.generic eklenir.
            //Array yerine liste oluşturabiliriz aşağıdaki gibi.
            //string array'i değil de string listesi eklenir isimler2 adında
            List<string> isimler2 = new List<string> { "Mehmet", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Osman");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
