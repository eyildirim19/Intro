using System;

namespace _6_Condition_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcının girdiği eğer 10'dan büyük girilen 10 sabitinden büyüktür...
            Console.WriteLine("Merhaba bir değer giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            // karar yapıları. programda belirli koşulların sağlanıp, sağlanmadığına karar veren program yapılarıdır. Karar yapıları ile program akışı koşula göre değiştirilebilir...

            /*
                if (kosul) // eğer kosul sağlanıyorsa. koşullu kod çalışsın...
                {
                    <kosullukod>
                }
             */
            // if
            // switch
            if (a > 10) // iki değeri karşışatır. koşul sağalanıyorsa (true) ise kodu çalıştır..
            {
                // koşullu kod.. => belirli bir koşul sonucu çalışan kod(lar)
                Console.WriteLine("Girilen değer 10 sabitinden büyüktür...");
            }

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}