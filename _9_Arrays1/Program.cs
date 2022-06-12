using System;

namespace _9_Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kisiler = new string[4];
            kisiler[0] = "Kübra";
            kisiler[3] = "Rüya";
            kisiler[1] = "İsmail";
            kisiler[2] = "Onur";

            // Length => dizinin uzunluğunu (eleman sayısını) verir...
            for (int i = 0; i < kisiler.Length; i++)
            {
                Console.WriteLine(kisiler[i]);
            }


            // elemanları tersten yazdırın...
            Console.WriteLine("*********1. yol*********");
            for (int i = kisiler.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(kisiler[i]);
            }
            Console.WriteLine("********2. yol**********");
            for (int i = kisiler.Length; i > 0; i--)
            {
                Console.WriteLine(kisiler[i - 1]);
            }



            int[] nums = new int[4];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            string[] names = new string[4];
            names[0] = "Ziya";
            names[1] = "Bayram";
            names[2] = "Ekrem";
            names[3] = "Aleyna";



            char[] chars = new char[3];
            chars[0] = 'C';
            chars[1] = 'R';
            chars[2] = 'Y';
            // foreach döngüsü => dizilerde ileri yönlü okuma yapmak için kullanılan özel bir döngüdür. çalışma zamanında in ifadesi ile chars ddizinin elemanları sırasıyla i değişkenine atanacaktır. 
            foreach(char i in chars)
            {
                Console.WriteLine(i);
            }






            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
