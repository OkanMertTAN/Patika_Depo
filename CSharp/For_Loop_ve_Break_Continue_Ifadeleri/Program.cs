using System;

namespace For_Loop_ve_Break_Continue_Ifadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Döngüsü 
            Console.Write("Lütfen bir sayı giriniz : ");
            int sayı = int.Parse(Console.ReadLine());

            //Tek mi , Çift mi ve toplamları 
            int tektoplam = 0 ;
            int cifttoplam = 0 ;

            for (int i = 1; i < sayı; i++)
            {
                if (i%2 ==1)
                {
                    cifttoplam += i;                
                    
                }
                else 
                    tektoplam += i;
            }
                Console.Write("Çift toplam : "+cifttoplam);
                Console.Write("Tek toplam : "+tektoplam);

            
            //break 
            int sayı1 =int.Parse(Console.ReadLine());

            for (int i = 1; i < sayı1; i++)
            {
                if (i==4)
                break;
                Console.Write(i);
            } 
            //continue
            for (int i = 1; i < sayı1; i++)
            {
                if(sayı1==4)
                continue;
                Console.Write(i);            
            }




        }
    }
}
