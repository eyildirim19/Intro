using System;

namespace _1_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // YORUM SATIRI 
            /*
             ÇOKLU YORUM SATIRI
            */

            // veri => işlenmemiş bilgi. bilgisiyarımız ram'inde sakladığımız ham bilgigidir.  verileri kullanılmak üzere pc'nin raminde saklanır... veriler saklamak için değişkenlere ihtiyaç vardır. Değişkenler;

            // bellekte açtığımız alanlardır..
            // değişken oluşturmak için veritiplerine ihtiyaç vardır...


            // verileri tipleri metinsel ve sayısal olmak üzere ikiye, sayısalları tamsayı ve ondalıllı sayı olmak üzere ikiye ayırırız...

            // sayısal tipler;
            // tam sayı tipler => byte,sbyte,short,ushort,int,uint,long,ulong
            // ondalıklı sayı tipleri => float,double,decimal

            // metinsel tipler;
            // char, string

            // birde mantıksal tip olan bool vardır ki. herşeydir..

            byte sayi = 1;
            int i = 500;
            int a; // değer atanmamış değişken

            double d = 3.1;
            char c = 'A';
            string isim = "ekrem";

            //  byte b = 500; byten için 500 değeri büyük bir sayıdır. atamaya çalıştığınızda derleyici hata verecektir..
            short shr = 500;

            short shr1 = -32767;
            ushort shr2 = 32767; //  u prefixli tipler işaretsiz tam sayıları ifade ederler.

            // değişkenlere atanan değerler (veri) değişken tipiyle aynı olmak zorundadır...
            //string dene = 4; // 4 değer tam sayı bir deperdir ve string tipi için uyumlu değildir..

            /*
             * 
             3       => tam sayı
             333     => tam sayı
             -3333    => tam sayı
             333333  => tam sayı
             33.3    => ondalıklı
             1.3     => ondalıklı
             3.1     => ondalıklı
            "ekrem"  => metin
            "c#"     => metin
            'A'      => karakter
             */



            // değişken isimleri rakam ile başlamaz..
            //int 1sayi = 1;
            int sayi1 = 1;

            // değişken isimlerinde özel karakter kullanılmaz.
            //int adi?soyadi;

            // değiken isimleri benzersiz olmalıdır..
            int sayi2 = 4;

            // int sayi2 = 1; // mevcut scope'da aynı isimden farklı değişken tanımlandığı için kullanılamaz. farklı scopelarda aynı isim kullanılabilir.. örnek scope; (scope {

            // scope açıp kapatmak için altgr + 7 tuşuna basabilirsiniz. kapatmak için altgr + 0 tuşunu kullabilirsiniz. açılan her scope kapatılmak zorundadır...

            {
                int k = 1;

                //int k = 3; bu scope'da k değişken ismi tanımlandığı için kullanılamaz....
            }

            {
                int k = 4;
            }



            // değişken tanımlarken c# ifadeleri (kodları) kullanılmaz...
            //int string= 1; string c# ifadesidir
            //int out= 1; out c# ifadesdir.
           // int Console = 1; Console c# ifasidir...

            Console.WriteLine("Hello World!");
        }
    }
}