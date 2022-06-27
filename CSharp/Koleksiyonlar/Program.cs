using System;


namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort 
            
            int[] sayılar = {30,60,90,120,150,0};

            Console.WriteLine("----Sırasız Liste----");

            foreach (var sayı in sayılar)
                Console.WriteLine(sayı);
            
            Console.WriteLine("----Sıralı Liste----");

            Array.Sort(sayılar);
             foreach (var sayı in sayılar)
                Console.WriteLine(sayı);

           Console.WriteLine("----Clear----"); 

            Array.Clear(sayılar,2,1);

            foreach (var sayı in sayılar)
                Console.WriteLine(sayı);

            Console.WriteLine("----Reverse----");

            Array.Reverse(sayılar);

            foreach (var sayı in sayılar)
               Console.WriteLine(sayı);

            Console.WriteLine("----İndexOf----");

            Console.WriteLine(Array.IndexOf(sayılar,150));

            Console.WriteLine("----Resize----");

            Array.Resize<int>(ref sayılar,7);
            sayılar[6] = 99;

            foreach (var sayı in sayılar)
                Console.WriteLine(sayı);

        }
    }
}
