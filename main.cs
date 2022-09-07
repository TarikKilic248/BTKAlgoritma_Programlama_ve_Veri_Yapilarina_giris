using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        //SortedList
        var kitapIcerigi = new SortedList();
        kitapIcerigi.Add(1, "Önsöz");
        kitapIcerigi.Add(50, "Değişkenler");
        kitapIcerigi.Add(40, "Operatörler");
        kitapIcerigi.Add(60, "Döngüler");
        kitapIcerigi.Add(45, "İlişkisel Operatörler");

        Console.WriteLine("İçindekiler");
        Console.WriteLine(new string('-', 25));
        Console.WriteLine($"{"Sayfalar",8} {"Konular",-33}");
        foreach (DictionaryEntry item in kitapIcerigi)
        {
            Console.WriteLine($"{item.Key,5} {item.Value,-33}");
        }
    }
}

