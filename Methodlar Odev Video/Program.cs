using System;
using System.Linq;

namespace Methodlar_Odev_Video
{
    class Program
    {
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Topla(int no1, int no2=30) // no2=30 kısmı eğer no2 verirsen o rakam,vermessen default value 30
        {
            return no1 + no2; 
            //veya 
            //var result = no1 + no2;
            //return result;
        }

        static int Add3(ref int no1,int no2)
        {
            no1 = 30;
            return no1 + no2;
        }

        static int Carpma(int no1, int no2, int no3=1) // 3. sayi verildiğinde çarpabilir, vermezsen 1 ile çarpar
        {
            return no1 * no2 * no3;     
        }
        static int Carpma(int no1, int no2, int no3, int no4) // istediğin kadar method overload yapabilirsin, böylelikle
                                                              // fazla veri verildiğinde o sayıdaki veri içeren methodu uygular
                                                              // yapacağın her işlem için ayrı overload yapmak yerine
                                                              // params kullanılır.Params methodun son değeri olmak zorunda
        {
            return no1 * no2 * no3 * no4;
        }

        static int ParamsToplama(params int[] no) 
        {
            return no.Sum();
        }
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //var sonuc = Topla(1,10) ;
            //Console.WriteLine(sonuc);

            //int no1 = 10;
            //int no2 = 30;
            //Console.WriteLine(no1); //no1 henüz 36'daki değer
            //var sonuc2 = Add3(ref no1, no2); //methodda ref ile özel değer tanımladığımız için artık methoddaki değer
            //                                //refsiz olsaydı, method içi değeri methodda uygular ve hafızada 36'yı tutardık.
            //                                //ref yerine out da kullanabilirsin,
            //                                //out ile olunca 36'da no1 değeri belirtmek zorunda değilsin,methodda belirt yeter
            //                                //ref ile olunca ise 36'da değer belirtmek zorundasın işlem başında
            //                                //dolayısı ile harici bir değer işlem yapacağında başta bir değer yoksa out, değer varsa ref
            //Console.WriteLine(sonuc2);
            //Console.WriteLine(no1);

            //Console.WriteLine(Carpma(2, 5, 10));
            //Console.WriteLine(Carpma(2, 4, 10, 3));

            Console.WriteLine(ParamsToplama(1, 2, 3, 4));
        }


    }
}
