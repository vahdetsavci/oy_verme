using System;
using System.Collections.Generic;

namespace oy_verme;

class Kullanici
{
    static List<Kullanici> kullanicilar;
    

    int id;
    string ad, soyad, kullaniciAd, emailAdres;

    static Kullanici()
    {
        kullanicilar =
        [
            new(1, "Adile", "Naşit"), new(2, "Ayşen", "Gruda"), new(3, "Metin", "Akpınar"), new(4, "Zeki", "Alasya"), new(5, "Münir", "Özkul"), new(6, "Kemal", "Sunal")
        ];
    }

    public Kullanici() { id = ID_Ata(); }

    internal Kullanici(int id, string ad, string soyad)
    {
        this.id = id;
        this.ad = ad;
        this.soyad = soyad;
        kullaniciAd = $"{ad}.{soyad}.{id}".ToLower();
        emailAdres = $"{kullaniciAd}@outlook.com";
    }

    internal static bool Kontrol(string _kullaniciAd)
    {
        return kullanicilar.Find(I => I.kullaniciAd == _kullaniciAd) != null ? true : false;
    }

    internal static void Ekle()
    {
        Kullanici K = new();
        Console.Write("Ad: ");
        K.ad = Console.ReadLine();
        Console.Write("Soyad: ");
        K.soyad = Console.ReadLine();
        Console.Write("Kullanıcı Adı: ");
        K.kullaniciAd = Console.ReadLine();
        Console.Write("e-mail Adres: ");
        K.emailAdres = Console.ReadLine();
        kullanicilar.Add(K);
        Console.WriteLine("Kullanıcı eklendi!");
    }

    private int ID_Ata() { return kullanicilar.Count + 1; }

    internal void OyVer(string secim)
    {
        int kategoriID = Sistem.Kontrol(secim,  1, 7);
        if (kategoriID > 0)
        {
            int oyMiktari = Kategori.oylar[kategoriID];
            Kategori.oylar[kategoriID] = ++oyMiktari;
            Console.WriteLine("Oy verme işlemi başarılı!");
        }
    }
}