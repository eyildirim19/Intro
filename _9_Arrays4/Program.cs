using System;

namespace _9_Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("En sevdiğiniz günü giriniz");
            //string gun = Console.ReadLine();
            // kullanıcından günler sırasıyla istenecek. bu günler ekrana son günden ilk güne kadar yazdırılacak (tersten)

            string[] gunler = new string[7];
            for (int i = 0; i < gunler.Length; i++)
            {
                Console.WriteLine($"haftanın {i + 1} . günü giriniz");
                gunler[i] = Console.ReadLine();
            }
            Console.WriteLine("************");
            for(int i=gunler.Length-1; i >= 0; i--)
            {
                Console.WriteLine(gunler[i]);
            }

            Console.ReadKey();
        }
    }
}
