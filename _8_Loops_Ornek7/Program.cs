using System;

namespace _8_Loops_Ornek7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jump deyimleri => döngü içerisine kullanılan döngüde sonraki adıma geçen veya döngü sonlandırmak için kullanılan ifadelerdir..BU 3 ifadenin ortak noktası alt satırdaki komutları çalıştırmamasıdır....

            // continue => sadece döngü içerisinde kullanılır.bulunduğu döngüde sonraki adıma geçmek için kullanılır
            // break; => switch ve döngü içerisinde kullanılır. Her ikisindende bulunduğu switchi veya döngüyü sonlandırmak için kullanılır
            // return => her yerde kullanılır. buldunduğu programı (metot) sonlandırmak için kullanılır.. (return'i daha sonra çok sık kullanacağız. şimdilik üzerinde durmuyoruz)

            int toplam = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    continue; // döngüde sonraki adıma geçmek için kullanılır...
                }
                toplam += i;
            }

            Console.WriteLine($"Toplam = {toplam}");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                break;

                Console.WriteLine("Dönüyoruz.....");
            }


            Console.WriteLine("Meehaba c#");

            Console.ReadKey();

        }
    }
}
