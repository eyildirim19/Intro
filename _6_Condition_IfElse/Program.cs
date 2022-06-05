using System;

namespace _6_Condition_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // girilen iki sayının karşılaştırılmasını yapalım. büyük sayıyı ekrana yazdıralım.. (not girilen iki sayının farklı olduğunu kabul ediyoruz..

            int sayi1, sayi2;
            Console.WriteLine("Lütfen 1. Sayıyı giriniz");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            int enbuyukSayi;
            if (sayi1 > sayi2)
            {
                enbuyukSayi = sayi1; // sayi1'in enbuyukSayiya atanması için sayi1'in sayi2'den büyük olması gerekir...
            }
            else // if koşulunun sağlanmama durumunda çalışır...
            {
                enbuyukSayi = sayi2; // 
            }

            Console.WriteLine($"En büyük sayı {enbuyukSayi}");
            


            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
