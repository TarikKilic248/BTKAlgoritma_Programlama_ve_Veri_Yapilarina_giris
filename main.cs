using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        //Hashtable uygulamasi

        //Başlığı okuma
        Console.WriteLine("Başlık giriniz: ");
        string baslik = Console.ReadLine();

        //Küçültme
        baslik = baslik.ToLower();

        //Hashtable
        var karakterSeti = new Hashtable()
      {
        {'ç','c'},
        {'ı','i'},
        {'ö','o'},
        {'ü','u'},
        {' ','-'},
        {'\'','-'},
        {'ğ','g'},
        {'.','-'}
      };

      foreach(DictionaryEntry item in karakterSeti)
      {
        baslik = baslik.Replace((char)item.Key, (char)item.Value);
      }

      //Ekrana yazdirma
      Console.WriteLine(baslik);
    }
}

