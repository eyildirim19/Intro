using System;

namespace _10_Methods_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // parametre => metoda scope dışından değer gönderimidir..
            // metotlar birden fazla parametre alabilir.. 
            Message();

            Message1("Selam");

            string v = "Hello";
            Message1(v);

            Message2("merhaba", "Büşra");
            Message2(v, "Kübra");
            Message2("Günaydın", "Aleyna");

            string[] names = { "Kübra", "Büşra", "Bayram", "İsmail" };
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            Array.IndexOf(names, "Ali");
            Array.IndexOf(nums, 2);


            Console.ReadKey();
        }

        // eğer private yazılmazsa metot erişim seviyesi default olarak privatetir.
        static void Message()
        {
            Console.WriteLine("Merhaba");
        }
        // string tipinde msj parametresi...parametre sadece metot gövdesinde kullanılabilir..
        static void Message1(string msj)
        {
            Console.WriteLine(msj); // parametre ile gelen veriyi ekrana yazdır...
        }
        static void Message2(string msj, string isim)// iki parametre alan metot...
        {
            Console.WriteLine($"{msj} {isim}");
        }
    }
}
