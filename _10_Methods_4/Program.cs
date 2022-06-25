using System;

namespace _10_Methods_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // metot geriye dönüş tipi örnek...
            int sayi1, sayi2, sonuc;
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı Giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz. (+,/,*,-)");
            char c = Convert.ToChar(Console.ReadLine());

            sonuc = IslemYap(sayi1, sayi2, c);

            Console.WriteLine($"işlem sonucu = {sonuc}");

            Console.ReadKey();
        }

        static int IslemYap(int s1, int s2, char islem)
        {
            int result = 0;
            if (islem == '+')
            {
                result = s1 + s2;
            }
            else if (islem == '*')
            {
                result = s1 * s2;
            }
            else if (islem == '-')
            {
                result = s1 - s2;
            }
            else if (islem == '/')
            {
                result = s1 / s2;
            }
            return result;
        }
    }
}
