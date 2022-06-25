using System;

namespace _10_Methods_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // output parametreler => metodun gövdesinden metot dışına değer çıkartmak için kullanılır..

            // normalde return ifadesi ile metot gövdesinden değer döneriz. eğer metot gövdesinden birden fazla değer dönülmesi gerekiyorsa return ifadesi çözüm olmayacaktır. çünkü return ile tek bir değer dönebiliriz..eğer metot gövdesinden birden fazla değer dönülecekse output parametreler tercih edilir..

            // output parametreler ikiye ayrılıralar; 
            // ref => ref argumanın referansını parametre olarak gönderirir. normalde output parameter değildir ancak bu mantıkla kullanılır....
            // out => out parameter metot gövdesinden dışarıya değer çıkarmak için kullanılır. inputun tam tersidir...metot gövdesinden birden fazla değer çıkartmak için kullanılılır..

            // ref out farkı
            // ref'te argumanın ilk değeri zorunludur, out'da değildir...
            // ref'te gövdede paremtreye değer atanmak zounlu değildir. out'da zorunludur

            int a = 1;
            Deneme(a);
            Console.WriteLine(a); // 1

            // b'yi ref ile Deneme'ye gönderdiğimiz için Deneme içerisinde ref'li parametrede değişiklik yapılırsa bu değişiklik b'ye yansır.çünkü ref ile argumanın değil referansı gönderilir...ref
            int b = 1;
            Deneme(ref b);
            Console.WriteLine(b);

            int c;
            Deneme1(out c);
            Console.Write(c);


            int sayi1 = 5, sayi2 = 10, v1, v2, v3;
            int r = IslemYap(sayi1, sayi2, out v1, out v2, out v3);
            Console.WriteLine($"Toplam Sonucu = {r}");
            Console.WriteLine($"Çarpma SonucU = {v1}");
            Console.WriteLine($"Çıkarma Sonucu = {v2}");
            Console.WriteLine($"Bölme Sonucu= {v3}");


            string str = "aa", str1 = "11";
            int num1,num2;
            bool durum = int.TryParse(str, out num1);// dünüşüm başarılı olursa sayıtı out ile çıkar, true dön
            bool durum2 = int.TryParse(str1, out num2);


            Console.WriteLine($"{durum} - {num1}");
            Console.WriteLine($"{durum2} - {num2}");

            // OOP 

            Console.ReadKey();
        }

        static int IslemYap(int s1, int s2, out int carpma, out int cikarma, out int bolme)
        {
            carpma = s1 * s2;
            cikarma = s1 - s2;
            bolme = s1 / s2;
            return s1 + s2; // toplamı geriye dön....
        }


        static void Deneme(int s1)
        {
            s1 = 2;
        }
        static void Deneme(ref int s1)
        {
            s1 = 2;
        }
        static void Deneme1(out int s1)
        {
            // metot out parameterlı olduğu için gövdede out parametreye değer atamak zorunludur...
            s1 = 19;
        }
    }
}