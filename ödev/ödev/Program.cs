
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Gizemli Sayıyı Bul'a Hoş Geldiniz!");
        Console.WriteLine("Zorluk Seviyelerinden Birini Seçin: ");
        Console.WriteLine("1. Başlangıç (1-8 Aralığındaki Gizemli Sayıyı Bulmaya Çalışın!)");
        Console.WriteLine("2. Şanslı (1-15 Aralığındaki Gizemli Sayıyı Bulmaya Çalışın!)");
        Console.WriteLine("3. İmkansız (1-25 Aralığındaki Gizemli Sayıyı Bulmaya Çalışın!)");

        int seviye = SecilenSeviye();

        int maksimumSayi;
        switch (seviye)
        {
            case 1:
                maksimumSayi = 8;
                break;
            
            case 2:
                maksimumSayi = 15;
                break;
            
            case 3:
                maksimumSayi = 25;
                break;
            
            default:
                
                Console.WriteLine("Geçersiz seviye. Varsayılan olarak başlangıç seviyesi seçiliyor.");
                maksimumSayi = 8;
               
                break;
        }

        Random random = new Random();
       
        
        int dogruSayi = random.Next(1, maksimumSayi + 1);

        Console.WriteLine($"Bir sayı tahmin edin (1-{maksimumSayi} arası):");

        int tahmin = -1;
        int tahminSayisi = 0;
        int tahminsansi = 3;

        while (tahmin != dogruSayi && tahminsansi > 0)
        {
            if (int.TryParse(Console.ReadLine(), out tahmin))
            {
                tahminSayisi++;

                if (tahmin < 1 || tahmin > maksimumSayi)
                {
                    Console.WriteLine($"Lütfen 1 ile {maksimumSayi} arasında bir sayı girin.");
                }
                else
                {               if (tahmin < dogruSayi)
                    {       Console.WriteLine("Daha yüksek bir sayı tahmin edin.");
                    }else if (tahmin > dogruSayi)
                    {
                        Console.WriteLine("Daha düşük bir sayı tahmin edin.");
                    }else{
                        Console.WriteLine($"Tebrikler! {tahminSayisi} tahminde doğru sayıyı buldunuz.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            }

            tahminsansi--;

            if (tahminsansi > 0)
            {
                Console.WriteLine($"Kalan tahmin hakkın: {tahminsansi}. Yeniden dene!:");
            }
            else
            {
                Console.WriteLine($"Bilemedin! Bir dahaki sefere. Doğru sayı: {dogruSayi}");
            }
        }
    }

    static int SecilenSeviye()
    {
        int seviye;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out seviye) && seviye >= 1 && seviye <= 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seviye. Lütfen 1, 2 veya 3 girin.");
            }
        }
        return seviye;
    }
}