using System;

namespace MyDictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cityPlateNo = new MyDictionary<int, string>();
            cityPlateNo.Add(35, "İzmir");
            cityPlateNo.Add(01, "Adana");
            cityPlateNo.Add(34, "İstanbul");

            int j = 0;

            for (int i = 0; i < cityPlateNo.Length; i++)
            {                
                Console.WriteLine(j + ". Sırada Kayıtlı Şehir Adı : "+cityPlateNo.value[i]+" Plaka No : "+cityPlateNo.key[i]);
                j = j + 1;
            }

        }
    }
}
