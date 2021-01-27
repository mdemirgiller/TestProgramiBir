using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] id;
        Tvalue[] employees;

        public MyDictionary()
        {
            id = new Tkey[0];
            employees = new Tvalue[0];
        }
        public void Add(Tkey idno, Tvalue employee)
        {
           Tkey[] tempId = id;
           Tvalue[] tempEmployees = employees;
           id = new Tkey[id.Length + 1];
           employees = new Tvalue[employees.Length + 1];

            for (int i = 0; i < tempId.Length; i++)
            {
                id[i] = tempId[i];
            }

            for (int j = 0; j < tempEmployees.Length; j++)
            {
               employees[j] = tempEmployees[j];
            }

            id[id.Length - 1] = idno;
            employees[employees.Length - 1] = employee;

        }

        public Tkey[] key
        {
            get { return id; }
           
        }
        public Tvalue[] value
        {
            get { return employees; }

        }

        public int Lenght
        {
            get { return employees.Length; }

        }

    }

}

