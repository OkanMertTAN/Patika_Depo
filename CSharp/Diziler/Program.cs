using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama

            string[] diller = {"İngilizce","Türkçe","Fransızca","Arapça"};
            string[] oyunlar = new string[2];

            //Dizi Atnama 
            oyunlar[1] = "GTA";

            Console.WriteLine(diller[3]);
            Console.WriteLine(oyunlar[1]);  

            
            //Dizilerde İşlem 
            //n tane sayının ort.

            Console.Write("Lütfe dizinin eleman saysını giriniz : ");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] dizi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0} sayıyı giriniz : ",i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            //Diziye değer verildi şimdi ort alma 
                int toplam = 0;


                foreach (var sayı in dizi)
                {
                    toplam += sayı; 
                }

                Console.Write(toplam/diziuzunlugu);
        }
    }
}
