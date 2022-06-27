using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While 
            //1 de başlayıp Console.ReadLine() yazdırılan sayıkadar ort alma
            Console.Write("Bir sayı girinizz : ");
            int deger = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= deger)
            {
                toplam += sayac;
                sayac++;
            }
                Console.Write("Ortalama : " +toplam/deger );

            //a dan z ye kadar sıralama
            char harfler = 'a';
            while (true)
            {
                Console.Write(harfler);
                harfler++;
            }

            //Foreach 

            string[] arabalar = {"BMW","Ford","TESLA"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            } 
        }
    }
}
