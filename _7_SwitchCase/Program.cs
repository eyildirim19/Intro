using System;

namespace _7_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SwitchCase Yapısı => bir değişikenin birden fazla koşulu olması durumda kullanılan yapılardır...
            Console.WriteLine("Lütfen il plakasını giriniz");
            string deger = Console.ReadLine();

            string il;
            #region elseifyapisi


            //if (deger == "19")
            //{
            //    il = "Çorum";
            //}
            //else if (deger == "34")
            //{
            //    il = "İstanbul";
            //}
            //else if (deger == "01")
            //{
            //    il = "Adana";
            //}
            //else if (deger == "06")
            //{
            //    il = "Ankara";
            //}
            //else
            //{
            //    il = "Geçersiz İl";
            //}
            #endregion
            switch (deger) // deger kontrol edilecek..
            {
                case "19":
                    il = "Çorum";
                    break; // case bitirir. switch'i sonlandırır
                case "34":
                    il = "İstanbul";
                    break;
                case "06":
                    il = "Ankara";
                    break;
                default: // caseler sağlanmadıysa default çalışır. else gibi düşünebilirsiniz...
                    il = "Geçersiz İl";
                    break;
            }

            int a = 1;
            int b = 1;

            switch (a)
            {
                default:
                    Console.WriteLine("Sayılar Eşit Değil");
                    break;
                //case b: // Not : case'ler sabit olmalıdır. değişken olmamalıdır...
                //    Console.WriteLine("Sayılar Eşit");
                //    break;
                case 1:
                    Console.WriteLine("Sayılar Eşit");
                    break;
                    //case 1: // Not : case'ler unique olmalıdır...
                    //    Console.WriteLine("Sayılar Eşit");
                    //    break;
            }

            if (a == b)
            {
                Console.WriteLine("Sayılar Eşit");
            }
            else
            {
                Console.WriteLine("Sayılar Eşit Değil");
            }

            Console.WriteLine(il);
        }
    }
}
