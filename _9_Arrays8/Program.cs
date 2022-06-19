using System;

namespace _9_Arrays8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 1 };
            Array.Resize(ref nums, 6);
            for (int i = 3; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            string[] isimler = new string[3];
            isimler[0] = "Bayram";
            isimler[1] = "Ziya";
            isimler[2] = "Ekrem";
            // Array.Resize =>dizinin uzunluğunu değiştirmek için kullanılır. 
            //ref komutu => referansı temsil eder. isimler dizini referansı ile Resize metoduna gönderiyoruz. ikinci parametre dizinin yeni uzunluğunu belirtiyoruz..
            Array.Resize(ref isimler, 4);
            isimler[3] = "İsmail";

            Array.Resize(ref isimler, isimler.Length + 1);
            isimler[4] = "Rüya";

            Array.Resize(ref isimler, 2); // yeni uzunluk mevcut uzunluktan az olursa belirtilen elemansayisina kadar olan elemanlar kalır, diğerleri silinir...
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
        }
    }
}