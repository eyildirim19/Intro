using System;

namespace _10_Methods_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(1, 2);

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int result2 = Sum(nums);

            int[] nums1 = { 1, 2, 3 };
            int result3 = Sum(nums1);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            int result4 = Sum(1, 2, 3, result, result3, result2);


            Kayit("ekrem", "onur");
            Kayit("ismail", "bayram","kübra");

            Console.ReadKey();
        }

        static int Sum(int s1, int s2)
        {
            return s1 + s2;
        }
        // params ifadesi => parametreleir dizi ile göndermek yerine , ile ayırıarak istediğiniz kadar gödnerebilirsiniz...
        static int Sum(params int[] s1)
        {
            int result = 0;
            foreach (int i in s1)
            {
                result += i;
            }
            return result;
        }
        static void Kayit(params string[] names)
        {
            foreach (string item in names)
            {

                Console.WriteLine(item);
            }
        }
    }
}
