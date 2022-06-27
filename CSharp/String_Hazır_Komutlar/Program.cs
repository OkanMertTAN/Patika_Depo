using System;

namespace String_Hazır_Komutlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string cümle = "Alcatraz adın bu mu ?";
            string cümle2 = "Ben Gould , beni duyabiliyor musun ? ";

            // Length : Karakter sayısı

            Console.WriteLine("Karakter Sayısı : {0} ",cümle.Length);

            // ToUpper : Tüm karakterleri büyütür
            // ToLower : Tüm karakterleri küçültür 

            Console.WriteLine(cümle.ToUpper());
            Console.WriteLine(cümle.ToLower());

            // Concat : Ekleme işlemi

            Console.WriteLine(string.Concat(cümle),"Alcatraz");

            //Compare ,CompareTo

            Console.WriteLine(cümle.CompareTo(cümle2));//0,1,-1

            //Contains
            Console.WriteLine(cümle.Contains(cümle2));
            Console.WriteLine(cümle2.StartsWith("Ben"));

            //İndexOf : BuLMA

            Console.WriteLine(cümle.IndexOf("Al"));

            //İnsert : İşaretlemeli Ekleme

            Console.WriteLine(cümle.Insert(0,"Gould'un tüm ümidi bizlerdik"));
            
            //PadLeft ,PadRight 
            
            Console.WriteLine(cümle + cümle2.PadLeft(50));
            Console.WriteLine(cümle.PadRight(35 ,'-') + cümle2);

            //Remove 

            Console.WriteLine(cümle.Remove(10));
            Console.WriteLine(cümle.Remove(5,3));

            //Replace 

            Console.WriteLine(cümle.Replace("Alcatraz","Oyuncu"));

            //Split 
            
            Console.WriteLine(cümle.Split(' ')[3]);

            //Substring 

            Console.WriteLine(cümle2.Substring(4,6));

            

        }
    }
}
