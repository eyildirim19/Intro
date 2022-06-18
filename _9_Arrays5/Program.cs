using System;

namespace _9_Arrays5
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan 5 adet sayı isteencek. Bu sayıların toplam ve ortalama değerlerini ekrana yazdırlacak
            int[] sayilar = new int[5];
            int i = 0;
            while (i < sayilar.Length)
            {
                Console.WriteLine($"{i + 1}. Sayıyı Giriniz");
                sayilar[i++] = Convert.ToInt32(Console.ReadLine());
            }

            int toplam = 0;
            for (i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            int ortalama = toplam / sayilar.Length;
            Console.WriteLine($"Sayıların Toplamı {toplam}");
            Console.WriteLine($"Sayıların Ortalaması {ortalama}");

            Console.ReadKey();
        }
    }
}
