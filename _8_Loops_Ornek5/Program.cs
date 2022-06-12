using System;

namespace _8_Loops_Ornek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1'den 100e kadar olan sayıları ekrana yazdıralım...
            int sayac = 1;
            while (sayac <= 100)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
            Console.WriteLine("**************************");
            for (int counter = 1; counter <= 100; counter++)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("***************************");
            int j = 100;
            while (j >= 1)
            {
                Console.WriteLine(j);
                j--;
            }
            Console.WriteLine("***************************");
            for (int k = 100; k > 1; k--)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("jdjskdjakd");

        }
    }
}
