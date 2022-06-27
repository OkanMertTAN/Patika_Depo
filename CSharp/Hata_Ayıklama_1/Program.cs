using System;

namespace Hata_Ayıklama_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
           try //Hata alması muhtemel satır
           {
             Console.WriteLine("Sayı Giriniz");
             int sayı1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Sayınız : "+sayı1);
           }
           
           catch(Exception hata1) //Hatayı yakalayan satır
           {
             Console.WriteLine("Hata : "+ hata1.Message.ToString());
           }
           
           finally
           {
               Console.WriteLine("İşleminiz tamamlandı.");
           }
           
           try
           {
               int a = int.Parse(null);
           }
           catch (ArgumentNullException hata2)
           {
               Console.WriteLine("Boş değer girdiniz");
               Console.WriteLine(hata2);
           }
           
           catch(OverflowException hata3)
           {
               Console.WriteLine("Çok büyük veya çok küçük bir sayı girdiniz!");
               Console.WriteLine(hata3);
           }
           
           finally
           {
               Console.WriteLine("İşlem başarıyla tamamlandı.");
           }


        }
    }
}
