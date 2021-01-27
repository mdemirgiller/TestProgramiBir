using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constractor - "ctor"
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
           //new diyerek yeni bir Array oluşturduğumuzda array'in bir önceki değeri uçacak
           //uçmaması için tempArray oluşturup items'i oraya emanet ediyoruz.
           //sonrasında baştaki items'i new array diyip, eleman sayısını bir arttırarak yeni oluşturuyoruz
            T[] tempArray = items;
            items = new T[items.Length+1];
            //Emanet verdiklerimizi geri alacağız;
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //sıfırdan başladığı için, eleman sayısı 6 ise, 5.'ye ekleyebilirsin
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }

    }
}
