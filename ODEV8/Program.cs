using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kaç adet sayı girmek istiyorsunuz? ");
        int adet = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;

        for (int i = 1; i <= adet; i++)
        {
            Console.Write("Sayı {0}: ", i);
            int sayi = Convert.ToInt32(Console.ReadLine());
            toplam += sayi;
        }

        double ortalama = (double)toplam / adet;

        Console.WriteLine("Girilen sayıların toplamı: " + toplam);
        Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);
    }
}
