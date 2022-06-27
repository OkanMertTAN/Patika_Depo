using System;
using System.Collections.Generic;
using System.Collections;

namespace Olay._6
{
    class Program
    {
        static void Main(string[] args)
        {   
             int sayı , sayac; 


           List<int> asalolan = new List<int>();
           List<int> asalolmayan = new List<int>(); 

           for (int i = 0; i < 20; i++)
           {    
               try
               {
                 Console.WriteLine("{0}. sayıyı giriniz : ",i+1);
                 sayı = int.Parse(Console.ReadLine());
                sayac = 0;
                for (int x = 2; x < sayı; x++)
                {
                    if (sayı%x ==0)
                    {
                        sayac++;
                    }
                    if (sayac == 0)
                    {
                        asalolan.Add(sayı);
                    }
                    else
                    {
                        asalolmayan.Add(sayı);
                    }

                }

               }
               catch 
               {
                   Console.WriteLine("Lütfen Pozitif Ve Sayısal Bir Değer Giriniz.");
                   
               }

           }
             
                 Console.WriteLine("-----------------------");

                asalolan.Sort();
                asalolmayan.Sort();

                Console.WriteLine("En Büyük ve En Küçük Sayılar");

                Console.WriteLine("En Büyükleri");

               // Console.WriteLine(asalolan.GetRange(0,2));
              //  Console.WriteLine(asalolmayan.GetRange(0,2));

                Console.WriteLine("En Küçükleri");

              //  Console.WriteLine(asalolan.GetRange(17,19));
              //  Console.WriteLine(asalolmayan.GetRange(17,19));

                 

                Console.WriteLine("Asal olan sayıların {0} elemanlıdır. : ",asalolan.Count);
                Console.WriteLine("Asal olmayan , sayıların {0} elemanlıdır. : ",asalolmayan.Count);

                






        }
    }
}
/*
: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList
sınıfını kullanara yazınız.)

- Negatif ve numeric olmayan girişleri engelleyin.
- Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
- Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/