using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, ProductName = "Kalem", CategoryId = 5, UnitInStock = 5, UnitPrice = 35 };


            //PascalCase(Class)    //camelCase(Class Değişkeni-Değişken)
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);







            //sadece toplam değerini göstermek istiyoruz, toplama sonucuna veri olarak ihtiyaç
            //yoktur. Bu nedenle void yapıp cw kullanarak yazdırıyoruz sonucu.
            //productManager.Topla2(3, 6);

            //toplama sonucuna veri olarak ihtiyacımız olabilir, örneğin aşağıdaki işlem için x2 yapmak gerekli olabilir
            //bu durumda public int ile başlayıp return ile belirttiğimiz methodu kullanıyoruz.

            //int toplamaSonucu = productManager.Topla(3, 6);

            //Console.WriteLine(2*toplamaSonucu);
            //Aşağıdaki de olur, ancak işlemi kafa karıştırmamak için bir int olarak tanımlayıp ilerliyoruz;
            //Console.WriteLine(2 * productManager.Topla(3, 6));


        }
    }
}
