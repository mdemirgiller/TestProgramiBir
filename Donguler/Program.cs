using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı Kursu";
            string kurs2 = "Geliştirici Kursu";
            string kurs3 = "Java Kursu";

            //array - dizi

            string[] kurslar = new string[] { 
                "Yazılımcı Kursu",
                "Geliştirici Kursu",
                "Java Kursu",
                "Osman"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Foreach Bitti");
        }
    }
}
