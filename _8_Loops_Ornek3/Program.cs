using System;

namespace _8_Loops_Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string k1 = "İ", k2 = "i";
            bool karsilastir = k1 == k2; // false

            char c = 'E';
            while (c == 'E') // C değişkeni E olduğu sürece. sayı iste, tekrar sor
            {
                Console.WriteLine("Lütfen sayıyı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Tekrar sayı girmek istermisin ? (E/H)");
                c = Convert.ToChar(Console.ReadLine()); // E dışında bir değer girilirse döngü  koşulda false döneceği için sonlanacaktır...
            }

            Console.ReadKey();

        }
    }
}
