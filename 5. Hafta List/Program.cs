using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ziyaretçilerin isimlerini içeren bir liste tanımlayın
        List<string> ziyaretciler = new List<string>()
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        // İsimleri tek tek ekrana yazdır
        Console.WriteLine("Ziyaretçi Listesi:");

        foreach (string isim in ziyaretciler)
        {
            Console.WriteLine(isim);
        }
    }
}
