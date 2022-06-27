using System;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama
            int x = 7;
            int y = 4;
            x = x+2;
            Console.WriteLine(y);
            y = y+2;
            Console.WriteLine(y);
            y += 2; 
            Console.WriteLine(y);

            //"||" ve "&&" operetörleri 

            bool dogru = true;
            bool yanlıs = false;

            if(dogru && yanlıs)
            Console.WriteLine("Perfect");    

            if (dogru || yanlıs)
            Console.WriteLine("Great");



            //İlişkisel Opertörler 
            // ,-,>,<,=,=>,!

            int a = 2;
            int b = 3;
            bool sonuc = a>b;

            Console.WriteLine(sonuc);

            sonuc = a!=b;
            Console.WriteLine(sonuc);

            // Aritmatik Operatörler            

            decimal ü  = 60;
            decimal p = 80;
           
            decimal sonucsayı  = ü/p;
            Console.WriteLine(sonucsayı);

            sonucsayı = ü++;
            Console.WriteLine(sonucsayı);
           






        }
    }
}
