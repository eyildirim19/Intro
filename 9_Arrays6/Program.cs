using System;

namespace _9_Arrays6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;


            // eğer dizi elemanları sabitse yukardaki atama yerine aşağıdaki atama tercih edilebilir...
            int[] nums1 = { 1, 2, 3 };
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            char[] chars = { 'A', 'B', 'C', 'D' };
            chars[0] = 'Z';
            //chars[4] = 'E';
            int[] numbers = { 4, 2, 10, 6, 11, 1, 4, 10, 4, 2 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                // IndexOf dizide arama yapar. Eğer aranan eleman dizide varsa, elemanın indexini, yoksa -1 döner. -1 döner çünkü -1 indexi olmaz..
                int index = Array.IndexOf(numbers, numbers[i]); // numbers dizisinde numbers[i] ci ara...
                int index2 = Array.IndexOf(numbers, numbers[i], index+1); // berlitilen indexten sonra ara...
                if (index2 == -1) // eğer true ise
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine($"Sayıların toplamı {sum}");
          
            


            // dizinin ilk elemanı en büyük kabul edildi..
            // dizinin sırasıyla (ilk eleman hariç)  enb elemanla karşılaştırlır.
            // eğer sıradaki eleman enb elemandan büyükse, sıradaki eleman enb kabul edilir...
            int enb = numbers[0]; // 10
            int enk = numbers[0]; // 1
            for (int i = 1; i < nums.Length; i++)
            {
                int current = numbers[i]; // 11
                if (current > enb)
                {
                    enb = current;
                }
                if (current < enk)
                {
                    enk = current;
                }
            }
            // dizi içerisindeki 10 adet elemanlardan sadece benzersiz olanların toplamını bulalım...
            Console.WriteLine($"Sayıların en büyüğü {enb}");
            Console.WriteLine($"Sayıların en büyüğü {enk}");

            Console.ReadKey();
        }
    }
}
