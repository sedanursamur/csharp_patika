using System;

namespace csharp_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = string.Empty;
            str1 = "Sedanur Samur";
            string ad = "Sedanur";
            string soyad = "Samur";
            string tamIsım = ad + soyad;

            //integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolean
            bool bool1 = 10 > 2;


            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //datetime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
