using System;

namespace oy_verme;

enum Baslik
{
    Cizgi
}

struct Ifade
{
    static string[] ifadeler;

    static Ifade()
    {
        ifadeler = ["--------------------------------------------------------------------------------------------"];
    }

    internal static void Yazdir(Baslik talep)
    {
        Console.WriteLine(ifadeler[(int)talep]);
    }

    internal static void Yazdir(string mesaj)
    {
        Console.WriteLine(mesaj);
        Yazdir(Baslik.Cizgi);
    }
}

// Hatalar
class GecersizSecim : Exception { internal GecersizSecim() : base("Geçersiz seçim yaptınız!"){} }