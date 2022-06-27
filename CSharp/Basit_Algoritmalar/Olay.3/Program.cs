using System;

}

namespace Olay._3
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


        }
    }
}
/*
 Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. 
 Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki 
 her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. 
 Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark
ücretini hesaplayan programın kodlarını yazınız.
*/