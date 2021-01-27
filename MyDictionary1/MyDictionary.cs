using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary1
{
    class MyDictionary<K,V>
    {
        K[] plateNo;
        V[] cityName;

        public MyDictionary() 
        {
            plateNo = new K[0];
            cityName = new V[0];
        }

        public void Add(K plate, V city)
        {
            K[] tempPlateNo = plateNo;
            V[] tempCityName = cityName;

            plateNo = new K[plateNo.Length + 1];
            cityName = new V[cityName.Length + 1];

            for (int i = 0; i < tempPlateNo.Length; i++)
            {
                plateNo[i] = tempPlateNo[i];
            }
            for (int i = 0; i < tempCityName.Length; i++)
            {
                cityName[i] =tempCityName[i];
            }

            plateNo[plateNo.Length - 1] = plate;
            cityName[cityName.Length - 1] = city;

        }

        public K[] key
        {
            get { return plateNo; }
        }
        public V[] value
        {
            get { return cityName; }
        }

        public int Length
        {
            get { return plateNo.Length; }
        }

    }
}
