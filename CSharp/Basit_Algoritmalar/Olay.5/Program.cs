using System;
using System.Collections;
using System.Collections.Generic;

namespace Olay._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Cümle Giriniz : ");

            string metin = Console.ReadLine();

            ArrayList sesli = new ArrayList();

            char[] sesli_harf = {'a','e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            char[] harfler = new char[metin.Length];
            harfler = metin.ToCharArray();

            foreach (var item in harfler)
            {
                foreach (var sharf in sesli_harf)
                {
                    if (item==sharf)
                    {
                        sesli.Add(item);
                    }
                }
            }

            foreach (var item in sesli)
            {
                Console.Write(item+" ");
            }
        }
    }
}
/*
 Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve 
 dizinin elemanlarını sıralayan programı yazınız.
*/