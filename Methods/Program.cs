using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        //methodları temel olarak
        //Don't repeat yourself(kendini tekrarlama) prensibi için yaparız
        static void Main(string[] args)
        {
            Add();
            Add();
            var result = Add2(20,30);
            Console.WriteLine(result);

            Console.WriteLine("---------");

            var result2 = Add3(10);
            Console.WriteLine(result2);

            Console.WriteLine("---------");

            int number1 = 20;
            int number2 = 100;
            var resualt3 = Add4(ref number1, number2);
            Console.WriteLine(resualt3);//referans tip ile çalışır
            Console.WriteLine(number1);//değer tip ile çalışır
           
            Console.WriteLine("---------");

            Console.WriteLine(Multiply(2,4));

            Console.WriteLine("---------");

            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine("---------");

            Console.WriteLine(Add5(1,2,3,4,5,6));

            Console.ReadLine();//uygulama dursun,sonlansın diye yazılır
        }
        //bir medhod ile çalışıldığında istediğimiz yerde çağırabiliriz,
        //tekrar tekrar yazmaya gerek kalmıyor, ayrıca tek merkezde kontrol edebilme imkanı sunmaktadır
        //bir ekleme işlemi yapacağımız bir method
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //parametreli method
        //Add2'yi kullanacak kişi buraya number1 ve number2 diye iki parametreyi buraya göndermesi gerekmektedir
        //static'in yanındaki void 'Git şunu yap' demektir.Git bir yere bir şeyler yaz, kayıt yap vs demektir.
        //oysa burada bir işlem yapmak istiyorum.
        //Bu yüzden ne tür bir veri döndürmek istiyorsak o tipi döndüryoruz.
        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        //default parametreli methodlarla çalışmak
        //default değerler her zaman methodun en snunda olması gerekir. mantıken de bu gereklidir
        //default parametresi verilmişse oraya veri girilirse girilen veri kullanılır
        //ancak eğer boş bırakılmışsa default değer kullanılır
        static int Add3(int number1, int number2=30)
        {
            var result2 = number1 * number2;
            return result2;
        }

        //challenge ref keyword ile çalışmak
        //ref: referans keyword'ı yukarıda tanımlanan number1 gibi
        //methodun içerisinde değişirse değeri atanan da değişmesi istenildiğinde kullanılır
        //ör, kredi türü var, müşteriye göre bir indirim kazandı ve bu indirim devam ediyorsa kullanılabilinir
        static int Add4(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //out keyword ile çalışmak
        //ref ile aynı mantıkla çalışır
        //ref'te ref edilen verinin set edilmesi(bir değer verilmesi) şarttır.
        //ancak out'ta buna gerek yoktur
        //!! out kullanıldığında değişkenin kullanılacak methodun içerisinde set edilmesi gerekir


        //method overloading
        // methodun imzası kullanılarak işlem yapılabilinir.
        //method ismi aynı yazılarak içerideki işlem değişiyorsa
        //herhangir bir problem çıkmaz, buna methodların overloading edilmesi aşırı yüklenmesi denir
        //programlamada sıklıkla kullanılan bir tekniktir
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1,int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //challenge params keyword ile çalışmak
        //params notasyonuyla dizi formatındaki parametreyi yollayabiliriz
        //methoda aynı tipte istediğimiz kadar parametre gönderebiliriz
        //ayrıca öncesinde bir paremtre yollanmışsa, params parametresi en sonda olmalıdır
        //aksi takdirde hata verir.(sonrasına yazılması gibi)
        //verilen parametre de methodda belirtilmeli yoksa boş döner
        static int Add5(int number,params int[] numbers)
        {
            //basit bir implementasyon
            //.Sum() bir fonksiyondur, hazır methodlardan biri
            //dizi sayısal olduğu için bütün sayıları birbiriyle topla anlamına gelir
            return numbers.Sum();
        }

    }
}
