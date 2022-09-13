using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var karakterYigini = new Stack<char>();

        for (int i = 65; i <= 90; i++)
        {
            karakterYigini.Push((char)i);
            Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi");
        }

        //Ek bilgi
        var dizi = karakterYigini.ToArray();

        Console.WriteLine("Yığından çıkarma işlemi için bir tuşa basın");
        Console.ReadKey();

        while (karakterYigini.Count! > 0)
        {
            Console.WriteLine($"{karakterYigini.Pop()} yığından çıkarıldı");
        }
    }

    private static void YiginOrnegi()
    {
        //Stack Tanımlama
        var karakterYigini = new Stack<char>();

        //Ekleme
        karakterYigini.Push('A');
        Console.WriteLine(karakterYigini.Peek());
        karakterYigini.Push('B');
        Console.WriteLine(karakterYigini.Peek());
        karakterYigini.Push('C');
        Console.WriteLine(karakterYigini.Peek());

        //Çıkarma
        Console.WriteLine(karakterYigini.Pop() + " Yığından çıkarıldı.");
        Console.WriteLine(karakterYigini.Pop() + " Yığından çıkarıldı.");
        Console.WriteLine(karakterYigini.Pop() + " Yığından çıkarıldı.");
    }
}

