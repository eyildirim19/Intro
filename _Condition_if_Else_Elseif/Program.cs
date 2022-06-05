using System;

namespace _Condition_if_Else_Elseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayı pozitif ise girilen sayı pozitif, negatif ise girilen sayı negatif, 0 ise girilen sayı 0 mesajı veren programı yazınız...
            Console.WriteLine("lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // bir birine bağlı koşulları bu şekilde karışık yazmaktansa else if yapılarını kullanırız..
            #region MyRegion


            /*
            if (sayi > 0)
            {
                Console.WriteLine("Girilen sayı pozitif");
            }
            else
            {
                if (sayi < 0)
                {
                    Console.WriteLine("Girilen sayı negatif");
                }
                else
                //if (sayi == 0)
                {
                    Console.WriteLine("Girilen sayı 0");

                }
            }
            */
            #endregion
            // else if => birbirine bağlı koşullar oluşturmak için kullanılır...
            if (sayi > 0)
            {
                Console.WriteLine("Sayı pozitif");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Sayı negatif");
            }
            else
            {
                Console.WriteLine("Sayı 0");
            }

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();

            // yeni bir projede girilen iki sayıdan büyük sayıyı ekrana yazdırın. eğer sayılar eşitse sayılar eşit mesajını veren programı yazın
        }
    }
}
