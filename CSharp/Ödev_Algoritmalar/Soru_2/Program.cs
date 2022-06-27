using System;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
             Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
             Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            */
            Console.Write("Bölünmesini istediğiniz sayıyı yazınız : ");
            int m =int.Parse(Console.ReadLine());

            Console.Write("Girmek istediğiniz sayı miktarını yazınız : ");
            int n =int.Parse(Console.ReadLine());

            int[] sayılar = new int[n];

            if (n>0 && m>0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Lütfen {0}, sayıyı giriniz : " ,i+1);
                    int ornek = int.Parse(Console.ReadLine());

                    sayılar[i] = ornek;
                }

                for (int j = 0; j < n; j++)
                {
                    if (sayılar[j] % m == 0)
                    {
                        Console.Write("Tam bölülenler : {0} ",sayılar[j]);
                    }

                    else
                    Console.Write("Tam bölünemenler : {0} ",sayılar[j]);
                }


            }
            else
            {
                Console.WriteLine("----Sayılar Pozitif Değil----");
            }


        }
    }
}
