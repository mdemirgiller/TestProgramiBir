using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<string> sehirler = new List<string>();//Bu generic bir class, c# dilinde default yer alan bir method List as a generic.
            //Console.WriteLine(sehirler.Count);//bu default programda Count tanımlı olduğu için hiçbirşey yapmadan ilerleriz. 
            //sehirler.Add("Osmaniye");         //ancak yeni bir generic tanımladığımız zaman, orada Count'u aşağıdaki gibi tanımlarız ;
            //Console.WriteLine(sehirler.Count);
            //Console.WriteLine("----------------");

            GenericList<string> sehirler3 = new GenericList<string>();//Yeni bir generic class oluşturup, 34'teki gibi class tipine T ve methodda T tipinde bir takma adlı veri ekleterek, 
                                                                      //burada İstanbul'u string olarak ekledik.
            Console.WriteLine(sehirler3.Count);
            sehirler3.Add2("İstanbul");
            Console.WriteLine(sehirler3.Count);//Count yazabilmek için bir Count property'si tanımladık, yalnızca get olarak. property çalıştığında arraylenght okuyup, Count adı altında bir int olarak kaydetecek.
            sehirler3.Add2("İzmir");
            sehirler3.Add2("Ankara");
            sehirler3.Add2("Bursa");
            sehirler3.Add2("Konya");
            sehirler3.Add2("Kayseri");
            Console.WriteLine(sehirler3.Count);

        }
    }

    class GenericList<T>
    {
        T[] _array;
        T[] _tempArray;

        public GenericList()
        {
            _array = new T[0];
        }
        public void Add2(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }

            _array[_array.Length - 1] = item;

        }

        public int Count
        {
            get { return _array.Length; }

        }

    }


}
