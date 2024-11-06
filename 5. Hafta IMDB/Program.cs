
using System.Collections.Generic;
using System.Linq;

class Film
{
    public string Isim { get; set; }
    public double ImdbPuani { get; set; }

    public Film(string isim, double imdbPuani)
    {
        Isim = isim;
        ImdbPuani = imdbPuani;
    }
}

class Program
{
    static void Main()
    {
        List<Film> filmListesi = new List<Film>();
        string devamEtmekIstiyorMu;

        do
        {
      
            Console.Write("Film ismini girin: ");
            string isim = Console.ReadLine();

            Console.Write("IMDb puanını girin: ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani))
            {
                Console.Write("Geçerli bir IMDb puanı girin: ");
            }

        
            filmListesi.Add(new Film(isim, imdbPuani));

            Console.Write("Yeni bir film eklemek istiyor musunuz? (Evet/Hayır): ");
            devamEtmekIstiyorMu = Console.ReadLine().ToLower();
        }
        while (devamEtmekIstiyorMu == "evet");

        
        Console.WriteLine("\nBütün Filmler:");
        foreach (var film in filmListesi)
        {
            Console.WriteLine($"- {film.Isim} (IMDb: {film.ImdbPuani})");
        }

    
        Console.WriteLine("\nIMDb Puanı 4 ile 9 Arasında Olan Filmler:");
        var filtrelenmisFilmler = filmListesi.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9);
        foreach (var film in filtrelenmisFilmler)
        {
            Console.WriteLine($"- {film.Isim} (IMDb: {film.ImdbPuani})");
        }

        
        Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler:");
        var aIleBaslayanFilmler = filmListesi.Where(f => f.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (var film in aIleBaslayanFilmler)
        {
            Console.WriteLine($"- {film.Isim} (IMDb: {film.ImdbPuani})");
        }
    }
}
