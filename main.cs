using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        OgretimElemani ogrGor = new OgretimElemani();
        Console.WriteLine(ogrGor);
    }

    public class OgretimElemani
    {
        //Property - Özellik
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        //Default Constructor
        public OgretimElemani()
        {

        }

        public override string ToString()
        {
            return $"{SicilNo,-5}" +
              $"{Adi,-10}" +
              $"{Soyadi,-10}" +
              $"{Cinsiyet,-10}";
        }
    }
}

