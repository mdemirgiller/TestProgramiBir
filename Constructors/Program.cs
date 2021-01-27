using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {ID=1, FirstName="Mehmet",LastName="Demirgiller",City ="İzmir" };
            //new Customer() dediğin zaman, aslında aşağıdaki public Customer() -Constructor çalışıyor. Consturctor'lar da method mantığı ile çalışır.

            Customer customer2 = new Customer(2,"Beste","Demirgiller","Eskişehir");//bu şekilde kullanabilmek için aşağıdaki constructor içine Customer(int id,string firstName,string lastName,string city)
                                                                                   //yazmam gerekli. Burayı yazarsan, default olarak çalışan yukarıdakini ezersin. İkisini de kullanmak
                                                                                   //için, overloading yaparak ctor yazıp, bir de defauld şekilde Customer() oluşturabilirsin.


            Console.WriteLine(customer1.City);
            Console.WriteLine(customer2.City);//bu şekilde customer2.City'yi yazmaz. çünkü aşağıda bu Class property'te City olarak tanımlı ancak, 
                                              //constructor'da city keyword'lu bir string nesnesi olarak tanımlı. Bu nedenle city nesnesini City Property'si ile eşlemek gerekli.
        }

    }
    class Customer
    {
        //default constructor, bu aşağıdakini ctor yazıp bıraksan  ya da bırakmasan farketmez default olarak çalışır.
        
        public Customer()
        {

        }

        public Customer(int id,string firstName,string lastName, string city)
        {
            //19.Satırda yazdığım durum nedeniyle bu aşağıdakileri yazdık. 
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
