using System;

namespace _9_Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1'den 100'e kadar olan sayıları bir dizide tutalım.. daha sonra bu dizinin elemanlarını ekrana yazdıralım...
            int[] nums = new int[100]; // 100 elemanlı bir dizi tanımladık...
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i + 1;
            }
            // elemanları ekrana yazdıralım...
            foreach (int i in nums) // nums dizinin içerisindeki her bir eleman i değişkenine aktarılır...
            {
                Console.WriteLine(i);
            }

            // 10'dan 100'e kadar olan sayıları 10'ar  bir diziye aktarıp. daha sonra dizinin elemanlarını ekrana yazdırınız...
            int[] onlar = new int[10]; // 10 20 30 40 50 60 70 80 90 100
            //for (int i = 0; i < 10; i++)
            //{
            //    onlar[i] = (i + 1) * 10;
            //}
            int sayac = 0;
            int deger = 10;
            while (sayac < 10)
            {
                //onlar[sayac] = (sayac + 1) * deger;
                //sayac++;
                onlar[sayac++] = sayac * deger;
            }

            foreach(int i in onlar)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
