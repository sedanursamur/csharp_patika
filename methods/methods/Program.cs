using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);



            int toplamSonucu;
            Methotlar instance = new Methotlar();
            instance.Topla(4, 5, out toplamSonucu);
            Console.WriteLine(toplamSonucu);

            int ifade = 999;
            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Sedanur", "Samur");


            //int sonuc2 = ornek.ArttirveTopla(a, b);
            //ornek.EkranaYazdir(Convert.ToString(sonuc2));
            //ornek.EkranaYazdir(Convert.ToString(a + b));
        }

    }


    class Methotlar
    {

        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }



        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }



        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri.ToString());
        }



        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }


        public int ArttirveTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 2;
            return deger1 + deger2;
        }
    }
    
}
