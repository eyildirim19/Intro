using System;

namespace _5_App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Int16   =>  short
            // Int32   =>  int
            // Int64   =>  long
            // Boolean =>  bool
            // Single  =>  float

            //int sayi1;
            //int sayi2;
            // Not : eğer değişkenler aynı tipte ise tek satırda da tanımlanabilir..
            byte sayi1, sayi2;
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz");
            sayi1 =   Convert.ToByte(Convert.ToInt16(Console.ReadLine())); // girilen değer stringdir. Çünkü console'dan alınan veya console yazaılan herşey string olmalıdır. Önce string değeri short'a dönüştürülür. Elde edilen short değer Byte dönüştürülür. Girilen değer eğer short ve byte için küçük ise dönüş yapılıp atama işlemi gerçekleşir. eğer girilen değer short için küçük byte için bütükse short dönüşümü yapılıp byte dönüşümünde overflowexception(taşma) hatası alınır..

            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi3 = Convert.ToInt16(Console.ReadLine()); // SHORTA DÖNÜŞTÜR SONRA OTOMATİK İNTE DÖNÜŞÜR.. otomatik inte dönüşmesi için girilen değerin short değer aralığında olmaıs gerekmektedir.. Bu yüzden degisken tipi ile dönüşüm metodunun aynı tipte olması gerekir...
        }
    }
}
