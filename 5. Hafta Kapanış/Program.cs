using System;
using System.Collections.Generic;

class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    public Araba()
    {
        UretimTarihi = DateTime.Now;
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine("Araba Bilgileri:");
        Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
        Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Renk: {Renk}");
        Console.WriteLine($"Kapı Sayısı: {KapiSayisi}");
        Console.WriteLine(new string('-', 20));
    }
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>();

        while (true)
        {
            Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
            string cevap = Console.ReadLine().Trim().ToLower();

            if (cevap == "h")
            {
                Console.WriteLine("Program sonlandırılıyor.");
                break;
            }
            else if (cevap == "e")
            {
                Araba yeniAraba = new Araba();

                Console.Write("Seri Numarası: ");
                yeniAraba.SeriNumarasi = Console.ReadLine().Trim();

                Console.Write("Marka: ");
                yeniAraba.Marka = Console.ReadLine().Trim();

                Console.Write("Model: ");
                yeniAraba.Model = Console.ReadLine().Trim();

                Console.Write("Renk: ");
                yeniAraba.Renk = Console.ReadLine().Trim();

            KapiSayisiGir:
                Console.Write("Kapı Sayısı: ");
                if (int.TryParse(Console.ReadLine().Trim(), out int kapiSayisi))
                {
                    yeniAraba.KapiSayisi = kapiSayisi;
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer giriniz.");
                    goto KapiSayisiGir;
                }

                arabalar.Add(yeniAraba);
                Console.WriteLine("Araba başarıyla üretildi ve listeye eklendi.");
            }
            else
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'e' veya 'h' giriniz.");
            }
        }

        if (arabalar.Count > 0)
        {
            Console.WriteLine("\nÜretilen Arabaların Bilgileri:");
            foreach (var araba in arabalar)
            {
                araba.BilgileriYazdir();
            }
        }
        else
        {
            Console.WriteLine("Hiç araba üretilmedi.");
        }
    }
}
