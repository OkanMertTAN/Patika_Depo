using System;
using System.Collections.Generic;

namespace Soru_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayılar = new List<int>(9);

            Console.WriteLine("Lütfen konsola 10 adet sayı giriniz : ");
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz :",i+1);
                sayılar.Add(int.Parse(Console.ReadLine()));  
            }
            
            foreach (var item in sayılar)
            {
                Console.Write("{0}",item+" ");
            }
            Console.WriteLine("-------------------");

            for (int i = 0; i < 10; i++)
            {
                sayılar[i] = sayılar[i] + (sayılar[i]*10/100);
            }

            foreach (var sayı in sayılar)
            {
                Console.Write(sayı +" " );

            }
            Console.Write("Uygulamadan çıkış için herhangibi tuşa basınız. "+Console.ReadLine());
            
        }
    }
}
/*
C# Console uygulamasında Elemanları kullanıcı tarafından dışarıdan girilen 10 elemanlı bir dizinin 
elemanlarını %10 arttıran ve ekrana yazdıran örnek:*/