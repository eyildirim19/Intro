using System;

namespace _7_SwitchCaseOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = 'A';
            Console.WriteLine("Lütfen bir harf giriniz");
            char harf = Convert.ToChar(Console.ReadLine());

            #region karşılaştırma if
            //if (harf == 'a' || harf == 'A')
            if (char.ToUpper(harf) == 'A' || char.ToUpper(harf) == 'E' || char.ToUpper(harf) == 'I' || char.ToUpper(harf) == 'İ' || char.ToUpper(harf) == 'O' || char.ToUpper(harf) == 'Ö' || char.ToUpper(harf) == 'U' || char.ToUpper(harf) == 'Ü')
            {
                Console.WriteLine("Sesli");
            }
            else
            {
                Console.WriteLine("Sessiz");
            }
            #endregion
            
            switch (char.ToUpper(harf))
            {
                case 'A':
                case 'E':
                case 'I':
                case 'İ':
                case 'O':
                case 'Ö':
                case 'U':
                case 'Ü':
                    Console.WriteLine("Sesli");
                    break;
                default:
                    Console.WriteLine("Sessiz");
                    break;
            }
            //Console.WriteLine($"Girilen Değer {harf}");
            //// char.ToUpper(char değeri); // girilen char değerini büyük harfe dönüştürür...
            //Console.WriteLine($"Girilen Değer {char.ToUpper(c)}");
            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
