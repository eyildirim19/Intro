using System;

namespace _10_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // metot programın tek parça halinde yazılmaktansa, modüler yazılmasını sağlayan(parçalara ayran) aynı zamanda bu modüllerin tekrar kullanılabilmesine imkan veren program parçalarıdır. metotları alt programlar gibi düşünebilirsiniz. örneğin console uygulamasını Main metodu içerisine yazılır..

            // Örnek kullanıdığımız metotlardan bazıları;
            // string metotları (ToUpper(),ToLower(),Trim()
            // Array metotlar Sort(),Reverse(),Resize(),IndexOf()
            // dizi extension metotları, Sum(),Min(),Max(),Avg()
            // Convert metotları


            /*
                örnek metot tanımı;
                <erisimseviyesi> <donustipi> <metotAdi>()
                {
                    <govde> 
                }
                erisimseviyesi => metota nerelerden erişleceğini belirtir..private,public,internal,protected erişim seviyelerini encapsulation kosunda detaylı inceleyeceğiz...kendimize yazdığımız metotlarını default private(özel) tır. eğer erişim seviyesi bellirlenmezse derleyici onu private kabul eder..
                
                donustipi   => metotlar metot içerisinde kullanılan varlıklardır. bir metot çağrıldığı yerde yapacağı işe göre dönüştipi belirlenmelidir. eğer metot dönüş tipi yoksa sadece çalışacaksa bu metotlara void metot denir. yani void boş dönüş  tipli metotlar tanımlamak için kullanılır.metot hem çalışşsın hemde işi bittikten sonra dönüş değeri versin bu tür metotlarada dönüş tipli metotlar diyorlar. dönüş tipi void olmayan yani boş dönmeyen metotlarada geriye değer döndüren metot denir...

                metotAdi => metot adı metonun program içerisndeki kimliğini ifade eder...

                metotgovdesi => metot içerisindeki çalışacak komutları ifade eder. yani programın kendisi...

                Main metod Program classında static olduğu için program classında nonstatic üye Main metodunda çağrılamaz..
             */

            MesajVer();
            MesajVer();
            MesajVer();

            Console.ReadKey();
        }

        // ilk metodumuz..
        private static void MesajVer()
        {
            Console.WriteLine("Merhaba");
        }

    }
}
