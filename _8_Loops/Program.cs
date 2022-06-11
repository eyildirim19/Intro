using System;

namespace _8_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
              DÖNGÜLER(LOOPS) =>

            Döngü => bir kodun veya kod bloğunun tekrar çalıştırılmasını (n defa) sağlayan yapıdır..

            C# dilinde 4 adet döngü vardır;
            for
            while
            do while
            foreach ( dizilerden sonra incelenecektir...)

            // for döngü => bir koşul doğrultusunda bir kodun veya kod bloğunun n adet çalıştırılmasını sağlar; döngünün çalışması için koşulun sağlanaması gerekiyor. koşulun sağlanmaıs içinde döngünün başlatılırken bir başlangıç değerinin olması gerekir. başlangıç değeri işlem adımlarını takip etmek için kullanılır...

            for(degisken; kosul; artim/azalim)
            {
                <kosullu kod>
            }

            önce değişken tanımlanır ve bir başangıç değeri atanır. (döngü başlatıldığında oluşturulur)
            bu değişken koşulda kontrol edilir karşılaştırma yapılır
            kosullu kod çalıştırılır
            artim veya azalim gerçekleşir

            Döngünün çalışması için koşulun sağlanması gerekir...
             */
            // kısır döngü
            //for (string i = "a"; i != "b";)
            //{
            //    Console.WriteLine("Hello World !");
            //}

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello World !");
            }
            // döngüler koşullu kodun çalıştırılması için koşulun sağlanması gerekir..
            // while döngüsün for döngüsünden farkı while döngüsüne koşullu döngü denir..yani işlem adımı sayılmama durumu varsa  bir sayaca ihtiyaç yoksa while döngüsü tercih edilir..
            // 1 defa 5 veya 105 gibi işlem adımlarının belli olduğu durumlarda for döngüsü tercih edilir..
            // ancak işlem sayısı belli olmadığında while döngüsü tercih edilebilir..Örnek isnetilen bilgi girilene kadar, veya bir dosyadaki veriler bitene kadar..
            int a = 0;
            while (a < 3)
            {
                Console.WriteLine("Hello World !");
                a++;
            }

            // do while döngüsü
            /*
             * do while döngüsünün diğer döngülerden farkı koşula bakmaksızın önce koşullu kodu çalıştırır, sonra koşula bakar..yani ilk adımda koşul sağlanmasa bile koşullu kod çalıştırılır. ilk adımdan sonra koşul sağlanırsa koşullu kod çalıştırılır..
                do
                {
                        <koşullu kod>
                }
                while(kosul)
             */

            int b = 0;
            do
            {
                Console.WriteLine("Hello Do While");
                b++;
            }
            while (b < 3);

            Console.WriteLine("Kapatmak için bir tuş bas");
            Console.ReadKey();
        }
    }
}
