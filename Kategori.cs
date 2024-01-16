using System;
using System.Collections.Generic;

namespace oy_verme;

static class Kategori
{
    internal static Dictionary<int, string> kategoriler; // Kategori ID, Kategori İsim
    internal static Dictionary<int, int> oylar; // Kategori ID, Oy miktarı
    
    static Kategori()
    {
        kategoriler = new Dictionary<int, string>()
        {
            {1, "Aksiyon"}, {2, "Belgesel"}, {3, "Bilim-Kurgu"}, {4, "Dram"}, {5, "Gerilim"}, {6, "Komedi"}, {7, "Korku"}
        };
        oylar = new() { {1, 0}, {2, 0}, {3, 0}, {4, 0}, {5, 0}, {6, 0}, {7, 0}, };
    }


    internal static void Listele()
    {
        Ifade.Yazdir("Film kategorileri");
        foreach (KeyValuePair<int, string> kategori in kategoriler)
        {
            Console.WriteLine($"{kategori.Key}.{kategori.Value}");
        }
    }

    internal static void SonuclariGoster()
    {
        int butunOylar = Hesapla();
        Ifade.Yazdir("Oylama Sonuçları");
        Console.WriteLine($"Oy kullanılma sayısı: {butunOylar}");

        int oy;
        double oyYuzde;
        for (int i = 1; i <= kategoriler.Count; i++)
        {
            oy = oylar[i];
            oyYuzde = (double)oy / butunOylar * 100;
            Console.WriteLine($"{i}.{kategoriler[i]}: {oy} => %{oyYuzde}");
        }
    }

    private static int Hesapla()
    {
        int toplam = 0;
        for (int i = 1; i <= oylar.Count; i++)
        {
            toplam += oylar[i];
        }
        return toplam;
    }
}