using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time >= 6 && time <= 12)
              Console.WriteLine("İyi Sabahlar");

            else if (time <= 18 ) 
                Console.WriteLine("Tünaydın");

            else 
                Console.WriteLine("İyi Geceler");

            //İkiside aynı yöntem 


            string sonuc = time >= 6 && time <=12 ? "Günaydın":time <=18 ? "Tünaydın":"İyi Akşamlar";

            Console.WriteLine(sonuc);
           

        }
    }
}
