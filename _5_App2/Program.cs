using System;

namespace _5_App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // çarpma, bölme ve çıkarma işlemlerini ayrı ayrı yapan programı yazınız..

            // Girilen iki sayının toplayan ve ekrana yazan program
            int sayi1, sayi2;

            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine()); // girilen sayıyı inte dönüştür ve sayi1'e ata

            Console.WriteLine("Lütfen 2. Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine()); // girilen sayıyı inte dönüştür ve sayi2'e ata

            int sonuc = sayi1 + sayi2; // 2 sayıyı topla ve sonuc'a ata..

           //Console.WriteLine("iki sayının toplam sonuc");
            Console.WriteLine($"İki Sayının toplamının sonucu = {sonuc}");

            Console.WriteLine($"{sayi1} sayısı ile {sayi2} sayısının toplamı = {sonuc}");
           //Console.WriteLine(sayi1 + " sayısı ile " + sayi2 + " sayısının toplamı = " + sonuc);

            
            // projemi paylaştım, ...sizinle....


            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}