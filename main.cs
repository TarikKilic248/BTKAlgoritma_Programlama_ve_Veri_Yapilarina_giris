using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        //Queue 
        //Tanımlama
        var karakterKuyrugu = new Queue<char>();

        //Ekleme
        karakterKuyrugu.Enqueue('a');
        karakterKuyrugu.Enqueue('e');
        Console.WriteLine(karakterKuyrugu.Count);

        //Çıkartma
        Console.WriteLine(karakterKuyrugu.Peek() + " başındaki harf");
        Console.WriteLine(karakterKuyrugu.Dequeue() + " kuyruktan çıktı");
        Console.WriteLine(karakterKuyrugu.Peek() + " başındaki harf");

        var sesliHarfler = new List<char>()
      {
        'a','e','ı','i','o','ö','u','ü'
      };

        var kuyruk = new Queue<char>();

        foreach (char k in sesliHarfler)
        {
            Console.WriteLine();
            Console.WriteLine($"{k} kuyruğa eklensin mi ? [E/H]");
            ConsoleKeyInfo secim = Console.ReadKey();
            Console.WriteLine();
            if (secim.Key == ConsoleKey.E)
            {
                kuyruk.Enqueue(k);
                Console.WriteLine($"{k} kuyruğa eklendi.");
                Console.WriteLine("Kuyruktaki eleman sayısı = " + kuyruk.Count);
            }
        }
    }

}

