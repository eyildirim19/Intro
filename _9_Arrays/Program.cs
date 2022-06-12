using System;

namespace _9_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 Array (Dizi) => birden fazla aynı tipteki değişkenlerin bir arada tutulduğu değişkenlerdir...

            değişken sayıyı (veri) arttıkça değişkenlerin yönetilmesi zorlaşır... ortahya gereksiz kod kalabalığı çıkacaktır...

                 <tip>[] diziAdi=new <tip>[elemanSayi]; 
                int[] sayilar = new int[4]; // 4 elemenalı bir sayı dizisi
            dizinin elemanlarına değer atamak veya değer okumak için dizinin indexi kullanılır.
            index [] ile gösterilir. dizinin elemanını verir.

            Not : c# dilinde indexler 0'dan başlar...
             // diziye değer atama
                sayilar[2] = 10; // sayıların 2. ekrana yazdır..
                sayilar[0] = 100;

                COnsole.WriteLine(sayilar[0]); sayiların 0. ekrana yazdır.

               string[] ogrenciler = new string[10] // 10 elemanlı bir string dizisi

             */

            int sayi1 = 1, sayi2 = 20, sayi3 = 10, sayi4 = 30;
            int enb = 0;
            if (sayi1 > sayi2 && sayi1 > sayi3 && sayi1 > sayi4)
            {
                enb = sayi1;
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3 && sayi2 > sayi4)
            {
                enb = sayi2;
            }
            else if (sayi4 > sayi1 && sayi4 > sayi2 && sayi4 > sayi3)
            {
                enb = sayi4;
            }
            else
            {
                enb = sayi3;
            }
            Console.WriteLine($"En büyük sayı {enb}");


            // new int[] ifadesi => bellekte 4 adet değişken oluşturup sayilar dizine set eder.. yani sayılar 4 elemanlı bir dizi olur..sayilar değişkeni 4 adet alanın referansını tutan bir yapı oldu. 
            // tipine bakmaksızın diziler referans tiplerdir.. çünkü birden fazla değişkenin değerini tutarlar.. 
            // new ifadesi ile tanımlanan herşey referans tiptir..
            int[] sayilar = new int[4];
            sayilar[0] = 10; // sayıların 1. elemanı 10
            sayilar[1] = 20; // sayıların 2. elemanı 20
            sayilar[2] = 30; // sayıların 3. elemanı 30
            sayilar[3] = 40; // sayıların 4. elemanı 40

            //sayilar[4] = 50; // dizinin 4. indexi olmadığı için program burada runtime(çalışma zamanı) hatası verekcektir...Dizinin olmayan indexi ile işlem yapılamaz....

            Console.WriteLine("Dİzi elemanlarını yazdırma");
            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[1]);
            Console.WriteLine(sayilar[2]);
            Console.WriteLine(sayilar[3]);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(sayilar[i]); // 10,20,30,40
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
