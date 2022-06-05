using System;

namespace _6_Condition_ifElse1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1, sayi2;

            Console.WriteLine("Lütfen 1. Sayıyı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2)
            {
                Console.WriteLine($"En büyük sayı {sayi1}");
            }
            else
            {
                Console.WriteLine($"En büyük sayı {sayi2}");
            }


            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
