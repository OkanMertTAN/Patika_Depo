using System;

namespace Olay._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı ,yüzbas,onbas,birbas;

            Console.WriteLine("3 basamaklı sayıyı giriniz : ");
            sayı = int.Parse(Console.ReadLine());

            yüzbas = sayı / 100;
            sayı = sayı - (yüzbas *100);
            
            onbas = sayı /10;
            sayı = sayı - (onbas *10);

            birbas = sayı;
            
            Console.WriteLine("{0} Yüzler Basamağı , {1} Onlar Basamağı , {2} Birler Basamağı",yüzbas,onbas,birbas);
            
            
        }
    }
}
/*
 Girilen 3 basamaklı sayının basamaklarına ayıran örnek 
 (Birler,Onlar,Yüzler Basamağındaki sayılar):
*/