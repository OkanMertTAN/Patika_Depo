using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
           string metin = "322";

            bool sonuc =int.TryParse(metin,out int sayı);
            Console.WriteLine(sayı);     

            if (sonuc)
            Console.WriteLine("Başarılı");
            
            else 
            Console.WriteLine("Başarısız");
        
            Metotlar ornek = new Metotlar();
            ornek.Topla(4,5,out int toplamsonuc);
            Console.WriteLine(toplamsonuc);
        
            int ifade = 999;
            ornek.EkrenYazısı(ifade);
        }
    }
    
    class Metotlar 
    {
        public void Topla(int deger1 ,int deger2,out int toplam)
        {
            toplam = deger1+deger2;
        }

        public void EkrenYazısı(string veri)
        {
            Console.WriteLine(veri);
        } 
    
        public void EkrenYazısı(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}
