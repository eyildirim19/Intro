using System;

namespace _3_TypeConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1";
            //  int b = (int)a; tipler farklı olduğu için dönüşüm yapılamaz...
            //farklı türden dönüşümler için tür dönüşümleri kullanılır... bu dönüşüm convert sınıfının metotları ile yapılır.

            byte b = Convert.ToByte(a); // a'nın türünü değitirerek b'ye ata...
            int i = 300;
            //byte b1 = i; a büyüktür b'den atanamaz..
            // explicty convert
            byte b1 = (byte)i;
            // Convert
            byte b2 = Convert.ToByte(i); //program burada i'Nin değeri byte aralı dışında olduğu için Overflow exception fırlatacaktır. yani hata verecektir..

            byte b3 = Convert.ToByte("1a"); // stringler sadece sayı formatında oldujklarında tam sayıya dönüştürülebilir. BU yüzden programımız 26. satırda format exception fırlatacaktır..yani hata verecektir...
            Console.WriteLine("Hello World!");
        }
    }
}
