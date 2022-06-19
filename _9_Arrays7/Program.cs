using System;
using System.Linq; // dizi üzerinden yardımcı metotlara erişmek için linq kütüphanesini ekliyoruz. Linqi detaylı c# konusunda inceleyeceğiz...

namespace _9_Arrays7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 adet benzersiz sayı istenecek. Girilen 10 adet sayının En büyüğü, En küçüğü, Toplam ve Ortalama değerleri bulunup ekrana yazdırılacak. EN son girilen sayılar tersten ekrana yazdırılacak...
            int[] nums = new int[5];
            #region forile
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine("Bir Sayı Giriniz");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    // IndexOf geriye değer döndüren metot. yani çalıştıktan sonra dizi içerisinde elemanı bulursa elemanın hangi indexe olduğunu (indexini), bulamazsa -1 döner...
            //    int index = Array.IndexOf(nums, num);
            //    if (index == -1) // aranan eleman dizide yoksa
            //    {
            //        nums[i] = num;
            //    }
            //    else
            //    {
            //        i--;
            //    }
            //}
            #endregion
            int j = 0;
            while (j < nums.Length)
            {
                Console.WriteLine("Bir Sayı Giriniz");
                int num = Convert.ToInt32(Console.ReadLine());
                if (Array.IndexOf(nums, num) == -1)
                {
                    nums[j++] = num;
                }
            }
            int enb, enk, toplam, ortalama;
            enb = nums.Max(); // max metodu dizinin en büyük elemanını geri döner...
            enk = nums.Min(); // min metodu dizinin ek küçük elemanını geri döner...
            toplam = nums.Sum(); // dizinin elemanlarını toplar geri döner..
            ortalama = (int)nums.Average(); // dizinin elemanlarının ortalamasını geri döner. Average metodu double dönüş tipli olduğu için bu atamayı cast etmek gerekir.

            Console.WriteLine($"Dizinin en büyük elemanı {enb}, en küçük elemanı {enk}, toplamı {toplam}, ortalaması {ortalama}");
            Console.WriteLine("******************");
            #region soraciklama

            // 4,10,30,1,20
            // Reverse
            // 20,1,30,10,4

            // Sort;
            // 1,4,10,20,30;

            // Reverse
            // 30,20,10,4,1
            #endregion
            Array.Sort(nums); // diziyi sıralar...
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("**********************");
            Array.Reverse(nums); // diziyi ters çevirir..
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
