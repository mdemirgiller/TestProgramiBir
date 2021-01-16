using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = 30 (çünkü integer-sayısal değer)

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999 (çünkü array - referans değeri)


        //int float double gibi sayısal değerler stack'te değerlenirir. Heap'e adreslenmez
        //array,class,string gibi değerler referans alır. stackte tanımlanır ve heap'e adreslenir.
        //bu nedenle adreslemeyi değiştirirsen, hep değişen adrese gider, değeri değiştirirsen değiştirdiğin değerde kalır.


        }
    }
}
