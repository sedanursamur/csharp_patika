﻿using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersiniz CSharp, Hoşgeldiniz!";
            string degisken2 = "CSharp";


            Console.WriteLine(degisken.Length);

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            Console.WriteLine(String.Concat(degisken, "Merhaba!"));

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Dersiniz"));


            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Sedanur"));
            Console.WriteLine(degisken.LastIndexOf("i"));


            Console.WriteLine(degisken.Insert(0, "Merhaba"));

            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken.PadRight(50) + degisken2);

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(6, 1));


            Console.WriteLine(degisken.Replace("CSharp", "C#"));

            Console.WriteLine(degisken.Split(' ')[1]);

            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));

        }
    }
}