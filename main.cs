using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        //Array Dizi tanımı
        int[] sayilar = new int[] { 5, 3, 11, 9, 7, 13, 17, 1, 15 };
        //Alternatif
        var sayilar2 = Array.CreateInstance(typeof(int), sayilar.Length);

        /*  
        sayilar2.SetValue(0, 0);
        sayilar2.SetValue(2, 1);
        sayilar2.SetValue(4, 2);
        sayilar2.SetValue(6, 3);
        sayilar2.SetValue(8, 4);
        */

        /*
          for (int i = 0; i <  sayilar.Length; i++)
          {
              sayilar2.SetValue(sayilar[i], i);
          }
        */

        sayilar.CopyTo(sayilar2, 0);

        //Alternatif
        var sayilar3 = new ArrayList(sayilar);

        //Sıralama
        Array.Sort(sayilar);
        Array.Sort(sayilar2);
        sayilar3.Sort();

        //Silme
        Array.Clear(sayilar, 2, 2);

        //Bulma
        Console.WriteLine(Array.IndexOf(sayilar, 1));


        //Array Dizi Dolaşma
        for (int i = 0; i < sayilar2.Length; i++)
        {
            //Console.WriteLine("sayilar[{0}] = {1} - sayilar2[{0}] = {2}",
            //         i, sayilar[i], sayilar2.GetValue(i));
            Console.WriteLine($"sayilar[{i}] = " + $"{sayilar[i],3}  -  " +
                       $"sayilar2[{i}] = {sayilar2.GetValue(i),3}  -  " +
                       $"sayilar3[{i}] = " + $"{sayilar3[i],3}");
        }

    }

}

