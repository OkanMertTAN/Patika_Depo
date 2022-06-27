using System;

namespace VeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            byte  sayı1 = 9;   // 1 byte
            sbyte sayı2 = -9;  // 1 byte Sadece Pozitif Sayılar
            
            short sayı3 = 6 ; // 2 byte 
            ushort sayı4 = 6; // 2 byte Sadece Pozitif Sayılar

            int sayıınt = 77; // 4 byte  
            Int16 sayı16 =77; // 2 byte 
            Int32 sayı32 = 55; // 4 byte
            Int64 sayı64 = 55 ; // 8 byte

            long sayılong = 2; //8 byte
            ulong sayıulong = 3 ; // 8 byte Sadece Pozitif Sayılar


            float r = 8; // 4 byte 
            double b = 5;// 8 byte
            decimal u = 66; //16 byte

            char harf = 'o'; // 2 byte
            string okan = "Okan Mert";// sınırsız
            

            bool dogru = true; 
            bool yanlıs = false;
            
            DateTime z = DateTime.Now;               
            //Şu andaki zamanı tutar.
            
            object e = 5;
            object q = "Kalem";
            object w = 5.8;

            //string ifadeler 

            string tamad = string.Empty;
            tamad = "Okan Mert TAN";

            //int ifadeler

            int o1 = 3;
            int o2 = 5;
            int o3 = o1 + o2;

            //bool    
      
            bool sayıd = 20>8;
   
            
            //Dönüşüm 

            int sayı99 = 99;
            string sayı98 = "98" ;    
             
            int sayıTop = sayı99 + Convert.ToInt32(sayı98); 
            Console.Write(sayıTop);
            Console.ReadLine();
        }
    }
}
