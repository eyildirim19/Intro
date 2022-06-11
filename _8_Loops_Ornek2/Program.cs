using System;

namespace _8_Loops_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı toplanacak");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0, toplam = 0, ortalama = 0;
            //for (int k = 0; k < n; k++)
            //{
            //    Console.WriteLine($"{k + 1} . Sayıyı Giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //}
            while (i < n)
            {
                Console.WriteLine($"{i + 1} . Sayıyı Giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                i++;
            }
            ortalama = toplam / n;
            Console.WriteLine($"Girilen sayıların toplamı {toplam}. Ortalaması {ortalama}");
            Console.ReadKey();
        }
    }
}
