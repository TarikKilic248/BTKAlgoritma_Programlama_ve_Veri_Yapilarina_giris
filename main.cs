using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World\n");

        //Hashtable tanımlama
        var sehirler = new Hashtable();

        //Ekleme
        sehirler.Add(6, "Ankara");
        sehirler.Add(34, "İstanbul");
        sehirler.Add(55, "Samsun");
        sehirler.Add(23, "Elazığ");

        //Dolaşma
        foreach (DictionaryEntry item in sehirler)
        {
            Console.WriteLine($"{item.Key,-5}" + $" - {item.Value,-20}");
        }

        //Anahtarları alma
        Console.WriteLine("\nAnahtarlar (keys)");
        var anahtarlar = sehirler.Keys;
        foreach (var item in anahtarlar)
        {
            Console.WriteLine(item);
        }

        //Değerler
        Console.WriteLine("\nDeğerler (Values)");
        ICollection degerler = sehirler.Values;

        foreach (var item in degerler)
        {
            Console.WriteLine(item);
        }

        //Elemana erişme
        Console.WriteLine("\nElemana erişme");
        Console.WriteLine(sehirler[55]);

        //Eleman silme
        Console.WriteLine("Eleman silme\n");
        sehirler.Remove(23);

        foreach (DictionaryEntry item in sehirler)
        {
            Console.WriteLine($"{item.Key,-5}" + $" - {item.Value,-20}");
        }

    }
}

