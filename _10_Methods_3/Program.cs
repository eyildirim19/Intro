using System;

namespace _10_Methods_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // metot dönüş tipi
            int snc = Topla(2, 2); // geriye 4 döner
            int a = Topla(snc, snc); // geri ? döner

            int num1 = 2, num2 = 2, num3;
            num3 = Carp(num1, num2); // geriye 4 döner

            int j = Bol(num1, num2);
        }
        static int Topla(int s1, int s2)
        {
            int result = s1 + s2;
            return result; // geriye result'i dön..
        }
        static int Carp(int s1, int s2)
        {
            return s1 * s2; // s1 ile s2'nin çarpımını dön...
        }
        static int Bol(int s1, int s2)
        {
            return s1 / s2;
        }
    }
}
