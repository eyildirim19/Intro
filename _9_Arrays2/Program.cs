using System;

namespace _9_Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2]; //bellekte 2 elemanlı bir instance (alan) oluştur..
            names[0] = "Ali";
            names[1] = "Veli";
            names = new string[3]; // bellekte 3 elemanlı yeni bir alan aç...
            names[2] = "AAA"; // 2 indexe aaa değerini set et...
            Console.WriteLine(names[1]); // dizin 1. indexi null olduğu için ekrana birşey yazmaz..çünkü null bir değer değildir. 
            string[] chars = new string[2];
            chars[0] = "A";
            chars[1] = "B";
            //  chars[2] = "C"; Runtime hatası alırız....çünkü dizinin 2. indexi yoktur.
            string[] tempChars = chars; // chars dizinini tempChars değişkenine ata...
            chars = new string[3]; // 3 elemanlı string dizi oluştur...
            chars = tempChars; // tempchars değişkenini chars dizisine ata...
            //chars[2] = "C"; // atama yapılamaz. çünkü 21. satırda tempChars dizinin referansı chars'a tekrar aktarıldı.  o referansda kaç eleman varsa chars dizinin eleman sayısı o kadar olur...
            foreach (string item in chars) // foreach döngüsü sadece dizilerde ileri yönlü okuma yapmak için kullanılan döngüdür.
            {
                Console.WriteLine(item);
            }
            int a = 1;
            //string[] str; // string dizi tipinde str değileşkeni
            //str = new string[3]; // bellekte eleman sayısı kadar alan açıyoruz...ve bu açılan alanların referansını str dizi değişkenine atar..yani diziler birden fazla elemanının referansını tutan elemanlanlardır..
            string[] chars1 = new string[2];
            chars1[0] = "A";
            chars1[1] = "B";
            string[] chars2;// referansı yok çünkü new ifadesinin kullanmadık...
            chars2 = chars1; // chars1 dizini chars2 dizine ata.. (bu atamada chars2'nin referansı chars1'e atanır)
            chars2[0] = "İ";
            Console.WriteLine(chars2[0]); // 
            Console.WriteLine(chars1[0]); // 


            // string hariç aşağıdaki değişkenlerin tipleri value type'tır. string özel tiptir. ayrıca incelenecektir..
            int j = 2;
            string str = "c#";
            char chr = 'C';
            bool durm = false;
            byte byt = 255;

            //byte byt2 = 256; //256 tam sayısı byte tipi için büyüktür..
            //byte[] byts = new byte[256]; // 256 adet sayı değeri tutan byte dizisi..
            int[] jj;
            string[] strstr;
            char[] chrchr;
            bool[] durmdurm;
            byte[] byts;

            jj = new int[11];
            //      jj = 1; bu atama yapılamaz çünkü jj'inin kendisi referans tutar..
            jj[10] = 1;// jj'nin 0 indexine 1 değeri ata. çünkü [0] ifadesi jj'nin 0. değeri ifade eder...

            int[] nums1, nums2; // dizi değişşken 
            nums1 = new int[100]; // 100 adet sayıyı nums1'e ata
            nums2 = new int[10]; // 10 adet sayıyı nums2'ye ata..



            Console.ReadKey();
        }
    }
}
