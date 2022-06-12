using System;

namespace _8_Loops_Ornek8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kadi = "", sifre = "";
            int n = 0;
            while (true)
            {
                Console.WriteLine("Kullanıcı Adı Giriniz");
                kadi = Console.ReadLine(); // admin

                Console.WriteLine("Şifre Giriniz");
                sifre = Console.ReadLine(); // 123
                if (kadi == "admin" && sifre == "123")
                {
                    break;
                }
                n++;
            }

            Console.WriteLine("Hoş Geldi Admin");
            Console.WriteLine($"Sisteme giriş saatiniz {DateTime.Now}"); // DateTime.Now => Now özelliği bulunudumuz tarih ve saati verir...
            Console.WriteLine($"{n} adet hatalı kullanıcı ve şifre denemesi");

            int k = 0;
            int toplam = 0;
            int ortalama = 0;
            while (k < 3)
            {
                Console.WriteLine($"{k + 1} . Sayıyı gir");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0 || sayi > 10)
                {
                    continue;
                }

                toplam += k;
                k++;

            }

            Console.WriteLine($"Girilen Sayıların Toplamı {toplam}");
            Console.WriteLine($"Girilen Sayıların Ortalaması {toplam / k}");

            Console.ReadKey();
        }
    }
}
