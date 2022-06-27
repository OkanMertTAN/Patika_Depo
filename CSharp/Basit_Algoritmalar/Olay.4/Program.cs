using System;
using System.Collections.Generic;
using System.Collections;

namespace Olay._4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayılar = new ArrayList();
            Matematik örnek = new Matematik();

            Console.WriteLine("--Büyük-Küçük Sayı Hessaplama Sistemi-- ");

           for (int i = 1; i <= 20; i++)
           {
              Console.WriteLine("{0}. sayıyı giriniz : "+sayılar.Add(int.Parse(Console.ReadLine())));
           }
            Console.WriteLine("-------------");

            sayılar.Sort();

            Console.WriteLine("En büyük 3 tanesi : ");

            
            ArrayList enbüyük = sayılar.GetRange(0,2);
            
            foreach (var item in enbüyük)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("-------------");
            
            Console.WriteLine("En küçük 3 tanesi : ");
            
            ArrayList enküçük = sayılar.GetRange(17,20);

            foreach (var item in enküçük)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("-------------");

            Console.WriteLine("Ortalama Hesaplama : ");

            Console.WriteLine("En Büyükleri : "+ örnek.Ortalama(enbüyük));
            Console.WriteLine("En Küçükleri : "+ örnek.Ortalama(enküçük));


            Console.WriteLine("Ortalama Toplamları Hesaplama : ");    

            örnek.Ortalamatop(enbüyük,enküçük); 



        }
    }
        public class Matematik 
        {
            public  ArrayList Ortalama(ArrayList arr )
            {
               int toplam = 0;

               foreach (int item in arr)
               {
                   toplam += item;
               }

                int ort = toplam/arr.Count;
                return arr;
            }

            public ArrayList Ortalamatop(ArrayList arr1 , ArrayList arr2)
            {
                int toplam1 =0;

                foreach (int item in arr1)
                {
                    toplam1 += item;
                }
                int ort1 = toplam1/arr1.Count;

                int toplam2 =0;

                foreach (int item in arr2)
                {
                    toplam2 += item;
                }
                int ort2 = toplam1/arr2.Count;
                return arr1;
                
                decimal toplam_ort = ort1 +ort2;

                Console.WriteLine("Toplam Ortalamaları :"+toplam_ort);
            }

            

        }

}
/*
Klavyeden girilen 20 adet saynın en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
(Array sınıfını kullanarak yazınız.)
*/