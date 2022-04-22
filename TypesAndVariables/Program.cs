using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value types: Değer tipleri
            //Console.WriteLine("Hello World!");
            //integer veri tipi -+ 2milyar... sayıları arasında değer alabilir
            //32bitlik yer kaplar
            int number1 = 2147483647;
            Console.WriteLine("Number1 is {0}",number1);
            //{0} parametresi indextir, 0'dan başlar, {0}virgülden sonraki ilk değişkeni belirtir
            Console.ReadLine();

            //long veritipi: int'e göre yaklaşık 2 kat daha fazla bellekte yer kaplar
            //long int'i kapsar
            //long'un sınırları 19 karakterden oluşur(-+)
            //64bitlik yer kaplar
            long number2 = 2147483648;
            Console.WriteLine("Number2 is {0}", number2);
            Console.ReadLine();

            //short veritipi
            //16bitlik yer kaplar
            //-32768+32767 arasında değer tutar
            short number3 = -32768;
            Console.WriteLine("Number3 is {0}",number3);
            Console.ReadLine();

            //byte veritipi
            //8bit yani 1bayt yer kaplar
            //0 ile 255 arasında sayı tutar
            byte number4 = 0;
            Console.WriteLine("Number4 is {0}",number4);
            Console.ReadLine();

            //bool veritipi
            //mantıksal veri tipidir. doğru(true) veya yanlış(false) değerlerini tutar
            //şart bloklarında kullanılır
            bool condition = true;

            //char veritipi
            //!string veritipi aslında bir karakter veritipidir
            //!string city = "Ankara"; city 6 karakterden oluşan bir dizidir
            //char kolaylıla int veritipine çevrilebilinir
            //Console.WriteLine("Character is : {0}",(int)character);
            char character = 'A';
            Console.WriteLine("Character is : {0}",(int)character);
            Console.ReadLine();

            //double veritipi
            //ondalıklı sayıları tutabiliyoruz
            //virgülden sonra 16 karakter tutabilir
            //64bitlik yer kaplar
            double number5 = 10.4;
            Console.WriteLine("Number5 is {0}",number5);
            Console.ReadLine();

            //decimal vertipi
            //doublenin kapsamından daha fazla verileri tutar
            //daha çok hesaplamalar için sayısal verileri kullanırken kulllanılır
            //daha çok hassasiyet gösteren işlemler için kullnaılır, ör, para tutarı 
            //virgülden sonra 28 tane değer tutabilir
            //decimal veri tanımlarken sayının sonuna "m" koymak gerekir. Küçük veya büyük farketmiyor
            //ondalık sayı yazılmayacaksa direk int gibi yazılır
            decimal number6 =10.4m;

            //enum(inam) veritipi
            //temel amaç program yazarken tekrar tekrar yazmamıza gerek bırakmıyor
            //!class'ın hemen dışında tanımladık
            //karşılaştırma yaparken pratiklik sağlar
            if (Days.Friday == Days.Sunday)
            {

            }
            //normalde aşağıdaki gibi yazmak gerekirdi
            //magic string adı verilir, bunu yapmamalıyız, değişiklik geldiğinde gidip hepsinde değişiklik yapmak gerekecek
            //if ("Friday")
            //{
            //}
            //enum'larda tip dönüşümleri önemlidir
            Console.WriteLine((int)Days.Friday);
            //sonuç 4 dönüyor çünkü 4. sırada yer alıyor.0'dan saymaya başlıyoruz
            Console.ReadLine();
            //!!
            //enum Days
            //{
            //    //bunlara enum sabitleri denilir
            //    //başlangıç değerini değiştirebiliyoruz, böylece o sayıdan saymaya başlıyor
            //    //herbirine farklı değer atayabiliyoruz. atamadıllarımız otomatik saymaya devam ediyor
            //    Monday = 10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            //}

            //var kayword ile çalışmak
            //bir değişken değildir fakat değişken tutmak için kullanılır
            //burada verilen number7'nin vertipi neyse, var'ın tanımladığı değişkenin veritipi o olarak algılanır.
            var number7 = 10;
            number7 = 'A'; 
            //bunun dödürdüğü sonuç int tipinde olur ve 65 döner
            //number7 = "A";
            //tekrar bir number7 tanımlatmak istenildiğinde izin vermez ilk verilen değerde kullanılır
            Console.WriteLine("Number7 is {0}", number7);
            Console.ReadLine();
        }
    }

    //veritipidir bilgi main'de verildi
    enum Days
    {
        //bunlara enum sabitleri denilir
        //başlangıç değerini değiştirebiliyoruz, böylece o sayıdan saymaya başlıyor
        //herbirine farklı değer atayabiliyoruz. atamadıllarımız otomatik saymaya devam ediyor
        Monday=10,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
    
}
