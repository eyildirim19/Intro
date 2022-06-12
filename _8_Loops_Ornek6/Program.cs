using System;

namespace _8_Loops_Ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vermek istediğiniz mesaj nedir?
            // kaç defa göstermek istersiniz
            Console.WriteLine("Vermek istediğiniz mesaj nedir");
            string mesaj = Console.ReadLine();

            Console.WriteLine("Bu mesajı kaç defa gösterelim??");
            int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(mesaj);
            }
            Console.WriteLine("*****************************");

            //0 den 100'a kadar çift sayıları ekrana yazdıralım...
            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***********************");
            // Kullanıcıdan 10 adet 1 ile 50 arasında sayı isteyelim...ve girilen bu sayıları toplayıp ekrana yazdıralım...Eğer sayı belirtilen aralıkta değilse kullanıcından sayı tekrar istensin...
            // 55, 30,40,10 = 80
            int toplam = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"1 ile 50 arasında {i + 1} . sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine()); //50 - 60 -100

                if (sayi >= 1 && sayi <= 50)
                {
                    toplam += sayi; // koşullu kod
                }
                else
                {
                    i--; // i'yi azalat
                }
            }

            Console.WriteLine("********************************");
            toplam = 0; // toplamı 0'la
            int c = 0;
            while (c < 3)
            {
                Console.WriteLine($"1 ile 50 arasında {c + 1} . sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine()); //51 - 60 -100

                if(sayi >=1 && sayi <= 50)
                {
                    toplam += sayi;
                    c++;
                }
            }

            Console.WriteLine($"girilen sayıların toplamı {toplam}");
            Console.ReadKey();
        }
    }
}