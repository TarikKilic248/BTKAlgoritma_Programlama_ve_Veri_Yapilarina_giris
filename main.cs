using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        //Array Dizi tanımı
        int[] sayilar = new int[] { 1, 3, 5, 7, 9 };
        //Alternatif
        var sayilar2 = Array.CreateInstance(typeof(int), 5);
        sayilar2.SetValue(0, 0);
        sayilar2.SetValue(2, 1);
        sayilar2.SetValue(4, 2);
        sayilar2.SetValue(6, 3);
        sayilar2.SetValue(8, 4);

        //Dolaşma
        for (int i = 0; i < sayilar2.Length; i++)
        {
            Console.WriteLine("sayilar[{0}] = {1} - sayilar2[{0}] = {2}",
                     i, sayilar[i], sayilar2.GetValue(i));
            //Console.WriteLine($"sayilar[{i}] = " + $"{sayilar[i]} - " +
            //         $"sayilar2[{i}] = {sayilar2.GetValue(i)}");
        }

    }

}

