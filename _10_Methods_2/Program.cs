using System;
using System.Threading;

namespace _10_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // metot dönüş tipi...
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

            int a = Array.IndexOf(nums, 100); // -1
            int b = Array.IndexOf(nums, 1);// 0

          

            string namesurname = "Ekrem Yıldırım";
            string name = namesurname.Substring(0, 5); // Ekrem

            // metodun geri dönmesi çağrılan yere işlem sonunda bir değer ile dönmesidir...

            // Not : void metotlar geri boş dönen metotlardır. Bunlara geriye değer döndürmeyen metotlarda denir...eğer void dışında herhangi bir tip belirterseniz o metot geriye o tipte değer dönmelidir...

            //return ifadesi altındaki hiç bir değeri çalıştırmaz. ve programı sonlandırmak için kullanılır. return bir jump deyimidir...eğer metot dönüş tipli ise return ile değer dönülür.

            MetotA();
            MetotB();

            Console.ReadKey();
        }
        static int MetotA()
        {
            // metotlar eğer geriye değer dönecekse return ifadesi ile dönüş tipinde değer dönmek zorundadır. yani metot dönüş tipi varsa return ifadesini yazmalısınız...

            // return ifadesi ile geriye 1 değerini dönüyoruz. yani buradaki return ifadesi programı sonlandırır.  Not: metot geriye değer döndüren metot ise return'un yanına dönüş tipi ile aynı değeri dönmeliyiz..
            //return "ekrem"; ekrem int değildir
            //return false; false int değildir
            //return; boş dönüyoruz. dönüş tipimiz inttir.
            return 1;
            Console.WriteLine("Ben metot a'yım");
        }


        static void MetotB()
        {
            // işleri yaptık....
           return; // not  eğer return; yazarsak buda dön anlamına gelir. ancak metot void ise return; ifadesi yazabiliriz return deger yazamayız...
            //metot void dönüş tipindeyse return yazmayız. return'ı sadece belli durumlarda yazarız.. void metotlarda
            Console.WriteLine("Ben metot b'yim");
        }
    }
}
