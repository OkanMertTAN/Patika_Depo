using System;

namespace Metot_Tanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
           //erişim_belirteci geridönüştipi metotadı(paremetre listesi /argüman)

            //{ 
                //komutlar;
                //return;
            //}

            int a = 10;
            int b = 90;

            Console.WriteLine(a+b);

            
            int sonuc = Carp(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            
            int sonuc2 = ornek.Artı(ref a,ref b);
            ornek.ekranyazısı(Convert.ToString(sonuc));
            
        }

        static int Carp(int değer1 ,int değer2)
        {
            return(değer1*değer2);
        }

    }

    class Metotlar
    {
        public void ekranyazısı(string veri)
        {
            Console.WriteLine(veri);
        }
    

        public int Artı(ref int değer1 , ref int değer2) //ref 
        {
            değer1 +=1;
            değer2 +=1;

            return değer1 * değer2;
        }

    }


}
