using System;
using System.Collections;
using System.Collections.Generic;


namespace Generic_
{
    public class Program
{
	public static void Main(string[] arg)
	{
		//Collections 
		//List<t> CLASS
		
		List<string> ülkeler = new List<string>();
		
		ülkeler.Add("Türkiye");
		ülkeler.Add("Almanya");
		ülkeler.Add("Fransa");
		ülkeler.Add("Rusya");
		ülkeler.Add("ABD");
		
		
		
		List<int> sayılar = new List<int>();
		
		sayılar.Add(60);
		sayılar.Add(80);
		sayılar.Add(3);
		sayılar.Add(73);
		
		//Count
		Console.WriteLine(sayılar.Count);
		Console.WriteLine(ülkeler.Count);
		
		//Foreach ve List.foreEach 
		foreach(var sayı in sayılar)
		   Console.WriteLine(sayı);
		
		
		foreach(var ülke in ülkeler)
		   Console.WriteLine(ülke);
		
		
		sayılar.ForEach(sayı=> Console.WriteLine(sayı));
		ülkeler.ForEach(ülke => Console.WriteLine(ülke));
		
		
		//Liste içinden çıkarma
		
		ülkeler.Remove("Almanya");
		sayılar.Remove(73);
		
		sayılar.RemoveAt(2);
		ülkeler.RemoveAt(0);
		
		sayılar.ForEach(sayı=> Console.WriteLine(sayı));  
		ülkeler.ForEach(ülke => Console.WriteLine(ülke));
		
		//	Liste içinde arama
		
		if(sayılar.Contains(80))
		{
		Console.WriteLine("Başarılı");
		}
		
		//Liste arama
		
		Console.WriteLine(ülkeler.BinarySearch("Türkiye"));
		
		//Diziyi listeye çevirme
		
		string[] matematik = {"Logaritma","Fonksiyonlar","Kümeler"};
		
		List<string> matList = new List<string>(matematik);
		
		//Listeyi Temizlemek
		
		matList.Clear();	
		
		//List içinde nesne tutmak
		
		List<Kullanıcılar> kullanıcılarListesi = new List<Kullanıcılar>();
		Kullanıcılar kullanıcı1 = new Kullanıcılar();
		
		kullanıcı1.Isim="Okan Mert";
		kullanıcı1.Soyisim = "TAN";
		kullanıcı1.Yaşı= 19;
		
		kullanıcılarListesi.Add(kullanıcı1);
		
		List<Kullanıcılar> yeniliste = new List<Kullanıcılar>();

       
		
	}
}

public class Kullanıcılar
{
 	private string isim;
 	private int yas;
 	private string soyisim;	


	public string Isim {get => isim;set =>isim =value;}
	public string Soyisim {get => soyisim;set => soyisim =value;}
	public int Yaşı {get => yas ;set =>yas = value ;}
 
 



}

}
