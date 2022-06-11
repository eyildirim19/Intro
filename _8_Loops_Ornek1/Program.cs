using System;

namespace _8_Loops_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen 5 adet sayının toplamı
            int toplam = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1} .Sayıyı Giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                //toplam = toplam + sayi;
                toplam += sayi;
            }
            Console.WriteLine($"Girilen sayıların toplamı = {toplam}");
            Console.WriteLine("Kapatmak için bir tuşa bas");
            Console.ReadKey();
        }
    }
}
