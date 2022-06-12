using System;

namespace _9_Arrays_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 3, sayi2 = 10, sayi3 = 5, sayi4 = 11;

            int[] sayilar = new int[4]; // new int[4] ifadesi ile 4 elemanlı bir dizi tanımlayıp sayilar dizisine atadık...
            sayilar[0] = sayi1; // sayi1'in değerini 0. indexe ata
            sayilar[1] = sayi2; // sayi2'in değerini 1. indexe ata
            sayilar[2] = sayi3; // sayi3'ün değerini 2. indexe ata
            sayilar[3] = sayi4; // sayi4'ün değerini 3. indexe ata

            int enb = sayilar[0]; // sayıların 0. indexteki elemanını enb kabul ediyoruz...
            for(int i=1; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enb)
                {
                    enb = sayilar[i];
                }
            }

            Console.WriteLine($"Sayıların en büyüğü {enb}");
            Console.ReadKey();

        }
    }
}
