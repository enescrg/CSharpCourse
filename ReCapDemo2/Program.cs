using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //aşağıda kolaylıkla loglama stratejisini değiştirebiliyoruz
            //burada stratejik deseninin de temellerini atmış oluyoruz
            customerManager.Logger = new DatabaseLogger(); //Burada soyut olan bir Interface'e somut olan loglanacak yer class'ını tanımlıyoruz
            //____________________//=new SmsLogger(); şeklinde sadece burada değişiklik yapılarak çağrılabilinir
            //yukarıda Logger'ı set etmeseydik hata verecekti çünkü Logger'ın kim olduğu belli olmayacaktı
            customerManager.Add();

            //Bu örnekte Interface'i tercih etmenin sebebi:
            //DataBase'de, File'da ve Sms'te loglamanın kodu farklı olmasıdır
            //DataBase ve File'de loglama kodları aynı olsaydı, sadece Sms'te farklı olsaydı bunu virtual yapardık
            //Aynı durum Abstract class'lar için de geçerlidir | Bir tane operasyonu herkes değiştirecek, bir tane operasyon da her yerde aynı olacaksa Abstract kullanmak gerekir


            Console.ReadLine();
        }
    }

    //Normalde CustomerManager class'ını da soyutlamamız gerekiyor, katmanlı mimariye geçince soyutlama yapacağız
    class CustomerManager //Müşteriyle ilgili iş operasyonlarını gerçekleştireceğimiz bir class
    {
        //alttaki property injection denilir | programcı main de ne yapacağını bilmesi gerekir
        //normalde constructor ile yaparız
        public ILogger Logger { get; set; } //Interface olan ILogger türünde Logger tanımlıyoruz
        public void Add()
        {
            //Add operasyonu yapıldığında Log işlemi de yapılsın diye buray yazıyoruz
            //Logger logger = new Logger(); //Logger class'ını buraya çağırıyoruz

            //DatabaseLogger logger = new DatabaseLogger(); //bunu böyle yazan programcılar da var ama bu da doğru bir kullanım değil | çünkü sürekli database'e loglama yapıyoruz
            //Bunu üstteki gibi yapmaktansa Interface'in nimetlerinden yararlanmamız gerekir
            //CustomerManage'ın içinde prop tanımlıyoruz ve onu buraya kolaylıkla çağırabiliyoruz
            Logger.log();//Normalde tanımlanan şey bir Interface(soyut), onu tek başına kullanamayız | ama somut bir şey atayabiliyoruz bunu main de yapıyoruz
            

            //Ancak yukarıdaki kod iyi bir kod değildir bu yuzden gözden geçirmek gerekecek
            Console.WriteLine("Customer added!");
        }
    }
    //Amaç: Kullanıcılarda bir bir müşteri eklediği zaman, bunu hangi kullanıcı hangi datayı, ne zaman logladı diye loglama yapmak istiyoruz
    //loglama bu amaçla kullanılır, biri bir şey çağırdığı zamna veritabanına bir kayıt daha atarız,
    //yani ör, Ahmet Add methodunu şu tarihte şu parametrelerle çalıştırdı

    //Ancak aşağıdaki kod iyi bir kod değildir bu yuzden gözden geçirmek gerekecek
    //class Logger //Bir class'ı böyle çıplak görürsek sorun olabileceğini anlamalıyız
    //_____________//Herhangi bir Interface'i, base'i implemente etmemiş ise bundan korkmak gerek
    //_____________//böyle çıplak olduğu için mecburi bunu new'leyip kullanmamız gerekecek
    
    
    //Loglama işlemiyse o class'ın mutlaka bir Base'i olmalı
    //DataBase dediğimizde, DataBase'e loglayacak kodu buraya yazıyoruz
    class DatabaseLogger :ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to database!");
        }
    } //yeni bir loglama yöntemi talebi geldiğinde gelip tüm Logger'ları değiştirmem gerekecek
      //değiştirdik diyelim bir müşteri metin dosyasına loglama istiyor, diğer müşteri database'e loglama istiyor ne olacak
      //demek ki burada yanlış bir implementasyon var
      
    //metin dosyasına loglama yapacak ortamı yapıyoruz
    class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to File!");
        }
    }

    //yeni bir loglama yöntemi istenildiğinde, mevcut hiçbir şeye dokumanaya gerek duymadan kolaylıkla ekleyip çağırma işlemini yapabiliyoruz
    class SmsLogger:ILogger
    {
        public void log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }

    interface ILogger
    {
        void log();
    }


}   

