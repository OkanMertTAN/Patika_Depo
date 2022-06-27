using System;

namespace Soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Lütfen bir cümle yazınız----");

            string  cümle = Console.ReadLine();
            string[] kelime = cümle.Split(" ");

            Console.WriteLine("Verilen kelime sayısı : {0}",kelime.Length);

            int harfsaydırma = 0;

            for (int i = 0; i < kelime.Length; i++)
            {
                char[] harfler = kelime[i].ToCharArray();

                harfsaydırma += harfler.Length; 
            }
            Console.WriteLine(harfsaydırma); 
            //Yeniden gözden geçirelecek !!!!!!!!!!!!
        }
    }
}
/*
Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/