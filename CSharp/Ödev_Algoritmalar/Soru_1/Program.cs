using System;

namespace Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
           Console.WriteLine("Lütfen n kadar sayı giriniz : ");
           int sayı = int.Parse(Console.ReadLine());

           if (sayı > 0)
           {
               int[] sayılar = new int[sayı];
                
               for (int i = 0; i < sayı; i++)
               {
                   Console.WriteLine("Lütfen sayıları giriniz : ");
                   int n =int.Parse(Console.ReadLine());

                   sayılar[i] = n;
               }

                for (int j = 0; j < sayı; j++)
                {
                    if(sayılar[j] % 2 == 0)
                    {
                        Console.WriteLine("Çiftsayı : "+ sayılar[j]);
                    }
                
                    else 
                    {
                        Console.WriteLine("Teksayı :"+sayılar[j]);
                    }
                
                
                }

           }
        }
    }
}
