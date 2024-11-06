using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Adım: 10 adet tam sayı verisi alacak bir dizi tanımlaması yapılır.
        int[] dizi = new int[10];

        // 2. Adım: Diziyi doldurur ve kullanıcıdan dzi elemanı alır
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            dizi[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nGirilen sayılar:");
        foreach (int sayi in dizi)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        // 3. Adım: Kullanıcıdan 11. dizi elemanı istenir. 
        Console.Write("\nYeni bir tam sayı girin (11. eleman): ");
        int yeniDeger = int.Parse(Console.ReadLine());

        // 11 elemanlı dizi tanımlanır
        int[] yeniDizi = new int[11];
        for (int i = 0; i < dizi.Length; i++)
        {
            yeniDizi[i] = dizi[i];
        }
        yeniDizi[10] = yeniDeger;

        // 4. Adım: Büyükten küçüğe sıralanır.
        Array.Sort(yeniDizi);
        Array.Reverse(yeniDizi);

        Console.WriteLine("\nBüyükten küçüğe sıralanmış dizi:");
        foreach (int sayi in yeniDizi)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();
    }
}