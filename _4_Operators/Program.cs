using System;

namespace _4_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a;
            // atama operatründeki en önemli kural sağdaki ile soldaki birbirine eşit olmak zorundadır..
            //byte b1 = false;
            //b1 = "A";
            //b1 = 3.1;

            // Aritmatik operatörler
            int r = a + b;
            r = a * b;
            r = a - b;
            r = a / b;
            r = a % b; //

            r = a + b * 2;
            // önce a ile 6 topla, sonra 2 ile çarp
            // işlem önceliği
            r = (a + b) * 2;

            // + operatörü metinsel ifadelerde birleştirme yapar.
            string s = "1" + "2";
            s = "ekrem" + "yıldırım";
            r = 21;
            r = r + 1;
            r += 1; // 33 sayıt ile aynıdır.  r ile 1'i topla r'ye ata.. aynı işlem *, /, için geçerlidir..

            r = r + 1;
            r += 1;
            // bir artım için kısa yol..
            r++; // önce işlem yapsa sonra arttır..
            ++r; // önce arttır sonra işlem yap...
            int i = 2;
            int y = ++i; // 3
            y = 3 + i++; // 6
            // karşılaştırma operatörleri.. => iki değeri karşılaştırmak için kullanılır..  > (büyük), >= (büyük eşit), < (küçük) , <= (küçük eşit), == (eşit), != (eşit değil) . iki değer karşılışatırlır ve sonuç olarak bool (true veya false) değeri döner..
            // 1 > 0
            bool sonuc = 3 > i; // False
            sonuc = 3 >= 3; // True;
            sonuc = 3 < 3;  //  False;
            sonuc = 3 <= 3; // True;
            sonuc = 3 == 3; // True;
            sonuc = 3 != 3; // False
            sonuc = 3 != 2; // True;

            int deger = 10;
            // orn ozel
            bool sonuc1 = deger > 3;
            bool sonuc2 = deger > 5;
            bool sonuc3 = sonuc1 == sonuc2;
            // orn ozel
            // mantıksal operatörler => birden fazla karşılaştırma birleştirmek için kullanılır. OrnOzel de olduğu gibi karşılaştırmaları ayrı ayrı yapmak yerine mantısal operatör ile birleştirerek tek satırda karşılaştırma yaparız.. && (ve) , || (veya)
            // ve'de karşılaştırmanın her iki tarafının doğru (true(olması gerekir.
            // veya'da karşışatırlaların birisinin doğru(true) olması yeterlidir
            // 3'den ve5'den büyükse true döner.. çünkü ve operetöründe her iki karşılaştırmanın true olması gerekir..
            bool sonuc4 = deger > 3 && deger > 5; // true
            sonuc2 = deger > 2 && deger < 2; // false
            sonuc4 = deger < 1 && deger < 100;
            sonuc = deger != 2 && deger != 100; // true
            sonuc = deger == 2 && deger == 100; // false

            bool sonuc5 = deger > 3 || deger > 5; // true
            sonuc5 = deger > 2 || deger < 2; // true
            sonuc5 = deger < 1 || deger < 100; // true;
            sonuc = deger == 2 || deger == 100; // false
        }
    }
}