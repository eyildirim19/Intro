using System;

namespace _6_Condition_ifOrn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 ile 100 arasında girilen iki sayının toplamını ekrana yazan program...eğer girilen sayı bu aralıkta değilse sonuç -1 yazsın..
            int a, b, sonuc;
            Console.WriteLine("1. sayıyı giriniz");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz");
            b = Convert.ToInt32(Console.ReadLine());
            // karışlaştırma operatörleri.. karşılaştırma operatörlerini birleştirmek için mantıksal operatörler kullanılır (&& veya ||) mantıksal operatör aşağıdaki gibi karmaşış ifler yazmamızı engeller. tek satırda birden fazla değer kontrol edebilebilir...

            #region mantiksal operatör kullanmadan karşılaştırma...
            if (a > 0)
            {
                if (a < 100)
                {
                    if (b > 0)
                    {
                        if (b < 100)
                        {
                            sonuc = a + b;
                        }
                    }
                }
            }
            #endregion

            if ((a > 0 && a < 100) && (b > 0 && b < 100))
            {
                sonuc = a + b; 
            }
            else
            {
                sonuc = -1;
            }
            Console.WriteLine($"Girilen sayıların toplamı {sonuc}");
            Console.WriteLine("Kapatmak için bir tuşa bas");
            Console.ReadKey();

            // Ödev => kullanıcıdan vize ve final notları istenecek.
            //
            // 1) vize 0 ile 100 arasıdna final 0 ile 100 arasında ise vize (%40) final (%60) notu hesaplanıp ortalama değişkenine aktarılarak ekrana ortalama yazdırılacaktır..

            // 2) eğer ortalama 0 ile 25 arasında ise ff, 26 ile 40 arasında ise dc, 41 ile 60 arasında ise  cc, 61 ile 80 arasında ise bb, 81 ile 100 arasında ise aa mesajını veren programı yazınız...

            // Ödevi github hesabına yükleyip whatsapp'tan hocaya profil linkinizi atınız...

        }
    }
}
