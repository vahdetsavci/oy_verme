using System;
using System.Collections.Generic;

namespace oy_verme;

class Program
{
    static void Main(string[] args)
    {
        Kullanici kullanici = new();

        Baslangic:
        Console.WriteLine();
        Console.Write("Kullanıcı Adı: ");
        if (!Kullanici.Kontrol(Console.ReadLine()))
        {
            Secim:
            switch (Sistem.SecimYap())
            {
                case 0:
                    goto Secim;
                case 1:
                    Kullanici.Ekle();
                    break;
                case 2:
                    goto Baslangic;;
            }
        }

        Ifade.Yazdir("Oy vermek istediğiniz kategoriyi seçiniz!");
        Kategori.Listele();
        kullanici.OyVer(Console.ReadLine());

        if (Sistem.CikisYap())
        {
            Kategori.SonuclariGoster();
        }
        else
            goto Baslangic;
    }
}
