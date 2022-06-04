using System;

namespace _2_TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        { // başlangıç scope // kodlar bu iki scope arasında yazıldığında çalışacaktır..
          // kodlarımızı ; ile bitiriyoruz. eğer ; kullanmazsak derleyeci hata verecektir
            #region aciklama

            //c# ta veri tipleri ikiye ayrılır; bunlar references type ve value typelerdadır. References type => referans tutan tipler. value type => değer tutan tiplerdir..
            // byte,sbyte,short,ushort,int,uint, long,ulong,float,double,decimal
            // char,string
            // bool

            // yukarıdaki tiplerden string hariç hepsi value tiptir..

            #endregion

            int a = 10;// 10 değerini a değişkenine ata.
            int b = a; // a'nın değerini b'ye ata...
            a = 11;
            // a = 11
            // b =10

            byte bt = 5;
            int i = 5;
            //int i1 = 5.1; 5.1 ondalıklı veri olduğu için i1'e atanamaz..ondalılı veri tipi seçilmesi gerekecektir...
            double d = 5; // 5 tam sayı
            double d1 = 5.1; // 5.1 ondalıklı sayı
            float f = 5.1f; // derleyici 5.1'i double olarak yorumlar.. f eki 5.1'in float olarak yorumlanmasını sağlar..
            decimal de = 5.1m; // m eki 5.1'in decimal olarak yorumlamasını sağlar...

            // d double
            // f float
            // m decimal 




            int sayi1 = 4;
            int sayi2 = 44;
            sayi1 = sayi2;

            // Not : bütün sayısal tipler aynı tiptir. küçükten büyüğe doğru atanabilir. bu atama işleminde derleyicimiz küçük tipi büyük tipe dönüştürürek atayacaktır.  bu işlemin adı implicity converttir..

            //string str = sayi2; aynı tipte olmadıkları için atama işlemi hatalıdır...
            // byte,sbyte,short,ushort,int,uint, long,ulong,float,double, decimal
            byte sayi3 = 4;

            // implicity convert => kapalı dönüşüm. küçük büyük tipe atandığında derleyici tarafından otomatik dönüştürülür..

            int sayi4 = sayi3; // sayi3'ün değeri sayi4'e atanır.. 

            short sayi5 = 500;
            // implicity convert
            int sayi6 = sayi5; // sayi5'in (short) deperi, sayi6 (int) atanır.
            int z = 4;
            //z'nin tipi int, k'nin short olduğu için ve z tip olarak k'dan büyük olduğu için bu atama otomatik (implicity) yapılamaz. Bu atama değer kaybı yaşababileceği için derleyici atamayı yapmıyor. Ama insiyatif alarak atamamızada müsade ediyor
            // dönüşümü açık olarak yapabiliriz . bu dönüşüme explicity dönüşüm denir. açık dönüşüm yaparken casting operatörü kullanılır.

            // casting => büyük tipin küçük tipe dönüşümüdür...
            short k = (short)z; // z'nin değerini shorta dönüştürerek ata..

            int l = 300;
            byte j = (byte)l;

            // Console penceresine j'Nin değerini yazdıralım...
            Console.WriteLine(j); //j'nin değerini console yazdır... ekrana değer kaybı ile yeni değeri yazdıracaktır...

            // type casting değer tiplerde (value type) dikkatli kullanılması gerekir

            Console.WriteLine("Hello World!");
        } // bitiş scope
    }
}
