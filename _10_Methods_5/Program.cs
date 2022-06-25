using System;

namespace _10_Methods_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method overloading (metot aşırı yükleme)

            // metotların aşırı yüklenmesi =>bir sınıf içerisinde aynı isimle birden fazla metot tanımlanmasıdır. aynı işi yapan birden fazla metot tanımlamak yerine o metodun birden fazla işi yapabilmesini sağlamak metot overloaddır...
            // metot overload'a aşağıdaki örnekleri verebiliriz..
            Convert.ToInt32(false);
            Convert.ToInt32("1");
            Convert.ToInt32(255);


            // metot overload => aynı isimde parametre tipleri ve sayıları farklı olan metotlar overload(aşırı yüklenmiş) metotlardır... yani farklı imzaya sahip metotlar overload edilmiş metotlardır. 

            // metot imzası metodun adını ve parametrelerini (tipi ve sayısı) ifade eden kavramdır..
            // overload edilmiş metotlar çağırma;
            Message(); // parametre almayan
            Message("Selam");
            Message("Hello", "Onur");
            
            Console.ReadKey();
        }

        static void Message()
        {
            Console.WriteLine("***********Selam***********");
        }

        static void Message(string msg)
        {
            Console.WriteLine($"***********{msg}***********");
        }
        static void Message(string msg,string name)
        {
            Console.WriteLine($"***********{msg} & {name}************");
        }
    }
}
