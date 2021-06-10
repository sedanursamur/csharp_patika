using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("kirmizi");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");


            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);


            foreach (int sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (string renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(x => Console.WriteLine(x));
            renkListesi.ForEach(x => Console.WriteLine(x));


            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(x => Console.WriteLine(x));
            renkListesi.ForEach(x => Console.WriteLine(x));

        }
    }
}
