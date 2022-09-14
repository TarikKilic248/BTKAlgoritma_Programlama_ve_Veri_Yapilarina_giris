using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayi giriniz");
        int sayi = Convert.ToInt32(Console.ReadLine());

        var sayiYigini = new Stack<int>();

        while (sayi > 0)
        {
            int k = sayi % 10;
            sayiYigini.Push(k);
            sayi = sayi / 10;
        }

        int i = 0;
        int n = sayiYigini.Count - 1;

        foreach (var s in sayiYigini)
        {
            Console.WriteLine($"{s} x {Math.Pow(10, n - i),3} = {s * Math.Pow(10, n - i),3}");
            i++;
        }

    }


}

