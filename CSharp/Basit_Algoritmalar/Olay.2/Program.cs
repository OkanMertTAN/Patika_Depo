using System;

namespace Olay._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Bir cümle giriniz : ");
            string metin = Console.ReadLine();

            string[] kelimesayısı = metin.Split(" ");  

            Console.WriteLine(kelimesayısı.Length);         


        }
    }
}
/*
 Klavyeden girilen bir cümledeki kelime sayısını bulunuz.
*/