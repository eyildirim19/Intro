using System;

namespace _9_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // if,döngü gibi blok yapılarda eğer tek satırlık bir ifade varsa scope zorunluğu yoktur..

            char[] isim = { 'e', 'k', 'r', 'e', 'm' };
            foreach (char c in isim)
                Console.Write(c);

            //string => reference type'tır. string aslında bir char dizisidir...
            string isim2 = "ekrem";
            Console.WriteLine(isim2.Length); // stringin uzunluğunu verir....
            char cc = isim[isim.Length - 1]; // m
            char i = isim2[isim2.Length - 1]; // m

            for (int j = isim2.Length - 1; j >= 0; j--)
                Console.Write(isim2[j]);

            foreach (char item in isim2) // isim2 içerisindeki herşey chardr
                Console.Write(item);

            string text = "er";
            //text[0] = 'e'; string sadece okuma yapılabilen (read only) bir tiptir.bundan dolayı özel bir dizidir..
            char k = text[0];


            // String içerisinde kullanılan extension (uzantı (ileride detaylı inceleyeceğiz) metotlar vardır. bu metotlar ile string içerisindeki veriler manipüle edilebilir..
            Console.WriteLine("*****************");
            string isimsoyisim = "ekrem yıldırım";
            Console.WriteLine(isimsoyisim.ToUpper()); // veriyi büyük harflere dönüştürür
            Console.WriteLine(isimsoyisim.ToLower()); // veriyi küçük harfe dönüştürür
            Console.WriteLine(isimsoyisim.Substring(0, 5)); // string içeisinden belirtilen uzunlukta karakter keser alır
            Console.WriteLine(isimsoyisim.Substring(6, 8).ToUpper());
            Console.Write("     bt    ".Trim()); // Trim => metin soldaki ve sağdaki boşluları siler.. 
            Console.Write("  akademi ile dersimize   ".Trim());
            Console.Write(" hoş geldiniz".Trim());
            Console.WriteLine(isimsoyisim.Replace("ı", "i")); // metin içierisindeki ı ları i ile değiştir...
            Console.WriteLine(isimsoyisim.IndexOf("y")); // y karakterinin indexini döner. y burada aranan elemandır. eğer aranan elema stringte varsa indexini, yoksa -1 döner
            Console.WriteLine(isimsoyisim.IndexOf("f")); // -1 döner..
            Console.WriteLine(isimsoyisim.Insert(isimsoyisim.Length ," yorulmuş..."));


            Console.ReadKey();
        }
    }
}
