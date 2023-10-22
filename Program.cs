using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hoş geldiniz!");
        string kullaniciAdi = "kullanici"; // Örnek kullanıcı adı
        string sifre = "sifre123"; // Örnek şifre
        int girisHakki = 3;

        while (girisHakki > 0)
        {
            Console.Write("Kullanıcı Adı: ");
            string girilenKullaniciAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string girilenSifre = Console.ReadLine();

            if (girilenKullaniciAdi == kullaniciAdi && girilenSifre == sifre)
            {
                Console.WriteLine("Giriş başarılı!");
                break;
            }
            else
            {
                girisHakki--;
                Console.WriteLine($"Hatalı giriş. Kalan giriş hakkı: {girisHakki}");
            }
        }

        if (girisHakki == 0)
        {
            Console.WriteLine("Giriş hakkınız tükendi. Uygulama kapatılıyor.");
            return;
        }

        while (true)
        {
            Console.WriteLine("Lütfen bir işlem seçin:");
            Console.WriteLine("1. Para Çekme");
            Console.WriteLine("2. Para Yatırma");
            Console.WriteLine("3. Bakiye Sorgulama");
            Console.WriteLine("4. Gün Sonu İşlemi");
            Console.WriteLine("5. Çıkış");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    ParaCekme();
                    break;
                case "2":
                    ParaYatirma();
                    break;
                case "3":
                    BakiyeSorgulama();
                    break;
                case "4":
                    GunSonuIslemi();
                    break;
                case "5":
                    Console.WriteLine("Çıkış yapılıyor.");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void ParaCekme()
    {
        Console.Write("Çekilecek miktarı girin: ");
        decimal cekilecekMiktar = decimal.Parse(Console.ReadLine());

        // Para çekme işlemi burada gerçekleştirilir
        // İşlem logları oluşturulur ve dosyaya yazılır
        LogIslem("Para Çekme", cekilecekMiktar);
        Console.WriteLine($"{cekilecekMiktar:C} çekildi.");
    }

    static void ParaYatirma()
    {
        Console.Write("Yatırılacak miktarı girin: ");
        decimal yatirilacakMiktar = decimal.Parse(Console.ReadLine());

        // Para yatırma işlemi burada gerçekleştirilir
        // İşlem logları oluşturulur ve dosyaya yazılır
        LogIslem("Para Yatırma", yatirilacakMiktar);
        Console.WriteLine($"{yatirilacakMiktar:C} yatırıldı.");
    }

    static void BakiyeSorgulama()
    {
        // Bakiye sorgulama işlemi burada gerçekleştirilir
        Console.WriteLine("Bakiyeniz: 1000.00 TL"); // Örnek bakiye
    }

    static void GunSonuIslemi()
    {
        // Gün sonu işlemi burada gerçekleştirilir
        // İşlem logları ve hatalı giriş denemeleri dosyaya yazılır
        LogIslem("Gün Sonu İşlemi", 0);
        Console.WriteLine("Gün sonu işlemi tamamlandı.");
    }

    static void LogIslem(string islem, decimal miktar)
    {
        string log = $"{DateTime.Now:dd/MM/yyyy HH:mm:ss} - İşlem: {islem}, Miktar: {miktar:C}";
        File.AppendAllText("log.txt", log + Environment.NewLine);
    }
}
