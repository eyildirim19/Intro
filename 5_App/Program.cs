using System;

namespace _5_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("çıktı");  // COnsole penceresine output yapar...
            // Console.ReadLine();  / Console penceresinden satır okumak için kullanılır. Kullanıcı değer girip enter tuşuna bastığında ReadLine komutu ile değer yakalanır..
            Console.WriteLine("Adınızı girin");
            string isim = Console.ReadLine();  // Girilen deperi isim değeşirkenine ata...

            //Console.WriteLine("Hoş geldin " + isim);
            // $ string formatlamak için kullanılır.. bu format çalışma zamanında metnin nasıl görüneceği belirler.. string içerisine değişken set etmek için { } süslü paranterler kullanılır
            Console.WriteLine($"Hoş geldin {isim}");

            // DateTime.Now =>şimdi zamanını gösterir
            Console.WriteLine($" {DateTime.Now} = Sisteme Giriş Saatiniz");
            Console.WriteLine($"Sisteme Giriş Saatiniz {DateTime.Now}");
            Console.WriteLine($"İşlem Sonucu {2 + 2}");


            // Programı bekletiyoruz...(Console'dan bir tuşa basana kadar')
            Console.WriteLine("Kapatmak için her hangi bir tuşa basınız...");
            Console.ReadKey(); // bir tuşa basılana kadar bekler
        }
    }
}
