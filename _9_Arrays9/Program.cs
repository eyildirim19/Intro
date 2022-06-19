using System;

namespace _9_Arrays9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[1];
            string cevap;
            do
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilar[sayilar.Length - 1] = sayi;

                Console.WriteLine("Tekrar Sayı Girmek istermisiniz? E/H");
                cevap = Console.ReadLine();

                if (cevap == "E")
                {
                    Array.Resize(ref sayilar, sayilar.Length + 1);
                }
            }
            while (cevap == "E");
            Console.WriteLine("*******************");
            Console.Write("Girdiğiniz Sayılar ;");
            foreach(int s in sayilar)
            {
                Console.Write(s);
            }
            Console.ReadKey();
        }
    }
}
