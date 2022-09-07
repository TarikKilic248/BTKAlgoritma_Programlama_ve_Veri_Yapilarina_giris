using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        //SortedList - Temmeller
        //Tanımlama
        var list = new SortedList()
        {
          {1,"Bir"},
          {2,"İki"},
          {3,"Üç"},
          {8,"Sekiz"},
          {5,"Beş"},
          {6,"Altı"},
        };

        list.Add(4, "Dört");
        list.Add(7, "Yedi");


        //Dolaşma
        foreach (DictionaryEntry item in list)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine("\nListedeki eleman sayısı : {0}", list.Count);
        Console.WriteLine("Listenin kapasitesi     : {0}", list.Capacity);
        list.TrimToSize();
        Console.WriteLine("Listenin kapasitesi     : {0}\n", list.Capacity);

        //Erişme
        //Key'e bağlı olarak
        Console.WriteLine(list[4]);
        //İndex'e bağlı olarak
        Console.WriteLine(list.GetByIndex(0));
        //Get -> Key
        Console.WriteLine(list.GetKey(0));
        //Liste sonundaki elemanın değeri
        Console.WriteLine(list.GetByIndex(list.Count - 1));

        var anahtarlar = list.Keys;
        Console.WriteLine("\nAnahtarlar:");
        foreach (var item in anahtarlar)
        {
            Console.WriteLine(item);
        }

        var degerler = list.Values;
        Console.WriteLine("\nDeğerler:");
        foreach (var item in degerler)
        {
            Console.WriteLine(item);
        }

        //Güncelleme
        if (list.ContainsKey(1))
        {
            list[1] = "One";
        }
        //Yeni Dolaşma 
        foreach (DictionaryEntry item in list)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }



    }
}

