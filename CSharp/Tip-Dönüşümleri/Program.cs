using System;

namespace Tip_Dönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilinçli Tür Dönüşüm 
           
            Console.WriteLine("-----Bilinçli Tür Dönüşümü-----");

            byte a =3;
            sbyte b =4;
            short c =6;

            int d = a+b+c;
            Console.Write(d);

            long e =d;
            Console.Write(e);


            string o = "Okan";
            char k = 'M';
            object n = o+k;

            Console.Write("İsim : "+n);

            //Bilinçsiz Tür Dönüşümleri
            
            Console.WriteLine("-----Bilinçsiz Tür Dönüşümü-----");

            int sayı1 = 99;

            Byte sayı2 = (byte)sayı1; 

            Console.WriteLine(sayı2);

            float sayı3 = 7.14f;
            byte sayı4 = (byte)sayı3; 
            Console.WriteLine("Sayı : "+sayı4);

            //To String Methodu

            Console.WriteLine("------To String-----");

            int sayı5 = 322;
            string isim1 = sayı5.ToString();
            Console.WriteLine("İsim : "+isim1);

            string isim2 = 32.5f.ToString();

            Console.WriteLine("İsim : "+isim2);

            //System.Console

            Console.WriteLine("-----System.Console-----");

            string isim3 ="20",isim4 = "90";

            int sayı6 ,sayı7; 
            int toplam;


            sayı6 = Convert.ToInt32(isim3);
            sayı7 = Convert.ToInt32(isim4);

            toplam =sayı6 + sayı7 ;
            Console.WriteLine("Toplam : "+toplam);

            //Parse
            Console.WriteLine("-----Parse-----");

            string metin1 = "10";
            string metin2 = "90.8";

            int sayı8 ,sayı9;

            sayı8 = Int32.Parse(metin1);
            sayı9 = Int32.Parse(metin2);

            Console.WriteLine("Sayı 1 : "+sayı8);
            Console.WriteLine("Sayı 2 : "+sayı9);

            //Hacerrank

            byte rakam1 = 7, rakam2 = 3;

            int yenirakam1, yenirakam2;

            yenirakam1 = Convert.ToInt32(rakam1);
            yenirakam2 = Convert.ToInt32(rakam2);

            int toplama = yenirakam1 + yenirakam2;

            Console.WriteLine(toplama);

        }
    }
}
