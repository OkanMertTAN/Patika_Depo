using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        public static void Main()
	 {
		//Dictionary : sözlük
		
		Dictionary<int,string> kullanıcılar = new Dictionary<int,string>();
		
		kullanıcılar.Add(18,"İsmail Taha");
		kullanıcılar.Add(20,"Okan Mert");
		kullanıcılar.Add(22,"Emre Bülent");
		
		//Dizilere Erişim 
		Console.WriteLine("--------");			
		Console.WriteLine(kullanıcılar[20]);
		
		foreach(var item in kullanıcılar)
		{
			Console.WriteLine(item);
		}

		//Count 
		
	 	Console.WriteLine("--------");
		
		Console.WriteLine(kullanıcılar.Count);

		//Contains
		
		Console.WriteLine("--------");
		
		
		Console.WriteLine(kullanıcılar.ContainsKey(22));
		Console.WriteLine(kullanıcılar.ContainsValue("Batuhan"));
		
		//Removo
		
		Console.WriteLine("--------");
		
		kullanıcılar.Remove(18);
		
		foreach(var item in kullanıcılar)
		{
			Console.WriteLine(item);
		}
		
		Console.WriteLine("--------");
		//Keys
		
		foreach(var item in kullanıcılar.Keys)
		{
			Console.WriteLine(item);
		}
		
		Console.WriteLine("--------");
		//Value
		
		foreach(var item in kullanıcılar.Values)
		{
			Console.WriteLine(item);
		}
		
      }    
    }
}