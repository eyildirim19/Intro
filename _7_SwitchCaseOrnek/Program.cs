using System;

namespace _7_SwitchCaseOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı Giriniz");
            b = Convert.ToInt32(Console.ReadLine());

            // if kontrolü
            if (a > b)
            {
                Console.WriteLine("A Büyük");
            }
            else
            {
                Console.WriteLine("B Büyük");
            }

            // switch kontrolü...
            switch (a > b)
            {
                case true:
                    Console.WriteLine("A Büyük");
                    break;
                default:
                    Console.WriteLine("B Büyük");
                    break;
            }
        }
    }
}
