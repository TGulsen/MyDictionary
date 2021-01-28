using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> sehirler = new Dictionary<int, string>();

            sehirler.Add(1, "Adana");
            sehirler.Add(2, "Adıyaman");
            sehirler.Add(3, "Afyon");
            sehirler.Add(4, "Ağrı");
            sehirler.Add(5, "Amasya");
            sehirler.Add(6, "Ankara");

            foreach (var sehir in sehirler)
            {
                //Console.WriteLine(sehir.Key + " plakalı şehir: " + sehir.Value);
            }


            MyDictionary<int, string> x = new MyDictionary<int, string>();

            x.Add(7, "Antalya");
            x.Add(8, "Artvin");
        }
    }
}
