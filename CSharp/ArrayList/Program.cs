using System;
using System.Collections;
using System.Collections.Generic;

namespace Array
{
   public class Program
{
	public static void Main(string[] arg)
	{
	
	//ArrayList 
		
		ArrayList liste = new ArrayList();
		
		liste.Add("Matematik");
		liste.Add("İsmail");
		liste.Add(1905);
		liste.Add(90);
		
		//İçindekini gösterme 
		
		Console.WriteLine(liste[2]);
		
		foreach (var item in liste)
			Console.WriteLine(item);
		
		Console.WriteLine("-----------------------------------");
		
		string[] dersler = {"İngilizce","Fizik","Kimya"};
		
		liste.AddRange(dersler);
		
		foreach (var item in liste)
			Console.WriteLine(item);
		
		
		Console.WriteLine("-----------------------------------");
		
		List<int> doğumtarihi = new List<int>(){2002,2004,2010,2015};
		liste.AddRange(doğumtarihi);
		
		foreach (var item in liste)
		Console.WriteLine(item);
		
		Console.WriteLine("-----------------------------------");		
		liste.Sort();//Hem string hem int olduğundan hata verecektir.
		
		Console.WriteLine("-----------------------------------");
		
		Console.WriteLine(liste.BinarySearch(4));
		
	    Console.WriteLine("-----------------------------------");

		liste.Reverse();
		
		foreach (var item in liste)
		Console.WriteLine(item);			
	   
		Console.WriteLine("-----------------------------------");

		liste.Clear();
		
		foreach (var item in liste)
		Console.WriteLine(item);	
	}
}

}
