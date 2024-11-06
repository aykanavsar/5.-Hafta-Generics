using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Bir sayı giriniz: ");
            string kullaniciGirdisi = Console.ReadLine();

            try
            {
                int sayi = int.Parse(kullaniciGirdisi);
                int karesi = sayi * sayi;
                Console.WriteLine($"{sayi} sayısının karesi: {karesi}");
                break; 
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        }
    }
}
