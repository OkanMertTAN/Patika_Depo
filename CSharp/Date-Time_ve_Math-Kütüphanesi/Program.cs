using System;

namespace Date_Time_ve_Math_Kütüphanesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****DateTime****");
			Console.WriteLine(DateTime.Now);//günün tarihi
			Console.WriteLine(DateTime.Now.Date);
			Console.WriteLine(DateTime.Now.Day);//günü
			Console.WriteLine(DateTime.Now.Month);//ayı
			Console.WriteLine(DateTime.Now.Year);//yılı
			Console.WriteLine(DateTime.Now.Hour);//saat
			Console.WriteLine(DateTime.Now.Minute);//dakika
			Console.WriteLine(DateTime.Now.Second);//saniye
			
			Console.WriteLine(DateTime.Now.DayOfWeek);//haftanın günün
			Console.WriteLine(DateTime.Now.DayOfYear);//yılın günü
			
			Console.WriteLine(DateTime.Now.ToLongDateString());//detaylı tarih
			Console.WriteLine(DateTime.Now.ToShortDateString());
			Console.WriteLine(DateTime.Now.ToShortTimeString());//detaylı saat
			Console.WriteLine(DateTime.Now.ToLongTimeString());
			
			//Ekleme İşlemleri
			Console.WriteLine(DateTime.Now.AddDays(5));
			Console.WriteLine(DateTime.Now.AddHours(3));
			Console.WriteLine(DateTime.Now.AddMinutes(7));
			Console.WriteLine(DateTime.Now.AddMonths(6));
			Console.WriteLine(DateTime.Now.AddSeconds(4));
			Console.WriteLine(DateTime.Now.AddMilliseconds(77));
			
			//DateTime Format 
			Console.WriteLine(DateTime.Now.ToString("dd"));//ayın günü :15
			Console.WriteLine(DateTime.Now.ToString("ddd"));//günün kısaltılmışı : sat
			Console.WriteLine(DateTime.Now.ToString("dddd"));//gün: Saturday

			Console.WriteLine(DateTime.Now.ToString("MM"));// YILIN AYI :02
			Console.WriteLine(DateTime.Now.ToString("MMM"));//Feb
			Console.WriteLine(DateTime.Now.ToString("MMMM"));//February
			
			Console.WriteLine(DateTime.Now.ToString("yy"));
			Console.WriteLine(DateTime.Now.ToString("yyyy"));
			
			//Math Kütüphanesi
			Console.WriteLine("****Math****");
			
			Console.WriteLine(Math.Abs(-10));//10
			Console.WriteLine(Math.Cos(20));
			Console.WriteLine(Math.Tan(24));
			Console.WriteLine(Math.Sin(8));
			
			Console.WriteLine(Math.Ceiling(22.1));//23
			Console.WriteLine(Math.Round(22.4));//22
			Console.WriteLine(Math.Round(22.8));//23
			Console.WriteLine(Math.Floor(22.9));//22
			
			Console.WriteLine(Math.Min(2,9));
			Console.WriteLine(Math.Max(4,2));
			
			Console.WriteLine(Math.Pow(3,4));//üslü sayılar3^4: 81
			Console.WriteLine(Math.Sqrt(9));//karekök : 3			
			Console.WriteLine(Math.Log(9));//logaritma
			Console.WriteLine(Math.Exp(3));//e üzeri 3 verir
			Console.WriteLine(Math.Log10(10));
			

        }
    }
}
