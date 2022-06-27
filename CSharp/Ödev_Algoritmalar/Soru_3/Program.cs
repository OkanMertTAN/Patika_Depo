using System;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet isim yazmak istiyorsunuz : ");
            int n = int.Parse(Console.ReadLine());
            
            String[] isimler ;

           if (n>0)
           {
                isimler = new string[n];
               for (int i = 0; i < n ; i++)
               {
                   Console.Write("{0}. ismi yazınız : ",i+1);
                   string x = Console.ReadLine();
                   isimler[i] = x ; 
               }
            
           
                Array.Sort(isimler);

                foreach (var isim in isimler)
                {
                    Console.WriteLine(isim);
                }
           }
                 else
            {
                Console.Write("Lüfen geçerli bir sayı giriniz ! ");
            }
        
        }
    }
}
/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın
*/