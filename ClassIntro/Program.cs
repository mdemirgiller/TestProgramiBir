using System;

namespace ClassIntro
{
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int izlenmeSayisi { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Pyton Kursu";
            kurs1.KursEgitmeni = "Mehmet Demirgiller";
            kurs1.izlenmeSayisi = 90;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c#";
            kurs2.KursEgitmeni = "Osman Yağmur";
            kurs2.izlenmeSayisi = 25;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "İngilizce";
            kurs3.KursEgitmeni = "Eddie Vedder";
            kurs3.izlenmeSayisi = 45;

            //Console.WriteLine(kurs1.KursAdi+" : "+kurs1.KursEgitmeni);
            //Console.WriteLine(kurs2.KursAdi + " : " + kurs2.KursEgitmeni);
            //Console.WriteLine(kurs3.KursAdi + " : " + kurs3.KursEgitmeni);
            //statik yerine dinamik için Döngü ile yapmak için aşağısı

            //array oluşturduk
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            //foreach ile döngü verdik
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +" : " + kurs.KursEgitmeni);
            }

        }
    }



 

}
