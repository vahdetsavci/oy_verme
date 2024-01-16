using System;

namespace oy_verme;

static class Sistem
{
    internal static int Kontrol(string deger, int sayi1, int sayi2)
    {
        string mesaj;

        try
        {
            int secim = Convert.ToInt32(deger);

            if (secim < sayi1 || secim > sayi2) throw new GecersizSecim();
            else return secim;
        }
        catch (FormatException) { mesaj = "Geçersiz formatta veri girdiniz!"; }
        catch (GecersizSecim gs) { mesaj = gs.Message; }
        catch (Exception) { mesaj = "Seçiminiz alınamadı!"; }

        return 0;
    }

    internal static int SecimYap()
    {
        Console.WriteLine("Sistemde kayıtlı değilsiniz! Devam etmek için kayıt olun veya başka bir Kullanıcı Adı girin!");
        Ifade.Yazdir("\r 1.Kayıt Ol \n 2.Başka bir Kullanıcı Adı Gir");
        return Kontrol(Console.ReadLine(), 1, 2);
    }

    internal static bool CikisYap()
    {
        Tekrar:
        Console.WriteLine("Uygulamadan çıkış yapılsın mı? E: Evet / H: Hayır");
        switch (Console.ReadLine().ToLower())
        {
            case "e":
                return true;
            case "h":
                return false;
            default:
                Console.WriteLine(new GecersizSecim().Message);
                goto Tekrar;
        }
    }
}