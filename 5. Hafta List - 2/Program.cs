using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Kahve isimlerini depolamak için bir liste oluşturuyoruz
        List<string> kahveIsimleri = new List<string>();

        // Kullanıcıdan 5 adet kahve ismi alıyoruz
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Lütfen {i}. kahve ismini girin: ");
            string kahveIsmi = Console.ReadLine();
            kahveIsimleri.Add(kahveIsmi);
        }

        // Girilen kahve isimlerini ekrana yazdırıyoruz
        Console.WriteLine("\nGirilen Kahve İsimleri:");
        foreach (string kahve in kahveIsimleri)
        {
            Console.WriteLine($"- {kahve}");
        }
    }
}
