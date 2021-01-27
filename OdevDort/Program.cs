using System;
using System.Collections.Generic;

namespace OdevDort
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary.MyDictionary<int, string> calisanBilgileri = new Dictionary.MyDictionary<int, string>();
            calisanBilgileri.Add(10, "Mehmet Demirgiller");
            calisanBilgileri.Add(20, "Beste Demirgiller");
            calisanBilgileri.Add(30, "Benek Demirgiller");

            for (int i = 0; i < calisanBilgileri.Lenght; i++)
            {
                Console.WriteLine( calisanBilgileri.key[i] + calisanBilgileri.value[i]);
            }
           
        }
    }
}
