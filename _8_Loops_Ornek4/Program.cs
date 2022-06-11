using System;

namespace _8_Loops_Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // float,double,decimal
            // float => ToSingle
            // double => ToDouble
            // decimal = > ToDecimal

            // n adet öğrencinin (öğrenci sayısı istenecek) vize ve final notları istenecek 
            // ortalama hesaplanacak. ekrana yazdırılacak... 
            // ortalama formulü (vize * 0.4f) + final * 0.6f)

            Console.WriteLine("Kaç adet öğrenci için hespalama yapılacak???");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Öğrenci Vize");
                float vize = Convert.ToSingle(Console.ReadLine()); // sayıyı float'a döndüştürdük

                Console.WriteLine("Öğrenci Final");
                float final = Convert.ToSingle(Console.ReadLine()); // sayıyı float'a döndüştürdük...

                float ortalama = vize * 0.4f + final * 0.6f;
                Console.WriteLine($"Öğrencinin Ortalaması= {ortalama}");
            }
        }
    }
}