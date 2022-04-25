using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //bir interfaces new yapılamaz çünkü tek başına bir anlamı yoktur, Interfaces ve Abstract soyut nesnelerdir
            //2. örnekte dosyalarla çalışacağız, farklı teknikleri de görmek için

            CustomerManager customerManager = new CustomerManager();
            //altta new'lediğimizde kolaylıkla veritabanları arasında geçiş yapabiliyoruz
            customerManager.Add(new SqlServerCustomerDal());
            //gerçek hayatta Interface'leri katmanlar arası geçişlerde sıklıkla kullanıyoruz
            //bundaki amaç uygulamanın bağımlılıklarını en aza indirgemek

            Console.ReadLine();
        }

        //aşağıdakini refactor yaptık | daha sonra baktığımızda dursun diye
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager(); //PersonManager class'ını çağırıyoruz
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Enes",
                LastName = "Çirağ",
                Address = "Van"
            };
            manager.Add(customer);

            //Aşağıdaki şekilde de yazılabilinir tamamen yazım tekniği ile alakalı
            manager.Add(new Customer { Id = 2, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Halil",
                LastName = "Kaya",
                Departmant = "Teacher"
            };
            manager.Add(student);

            manager.Add(new Student { Id = 2, FirstName = "Ali Eymen", LastName = "Tekiner", Departmant = " " });
        }
    }
    //Interface soyut nesnedir
    //tek başına hiçbir anlam ifade etmez
    //interface'ler inheritance değillerdir ama c# ve java gibi dillerde, inheritance gibi kullanılabiliniyor
    interface IPerson //isimlendirme standardı "I" ile başlatmaktır, yanında kullanılacak ifade de büyük harfle başlar
    {
        //temel amacı temel nesne oluşturup, bütün nsneleri ondan implemente etmektir
        //interface'leri sevis implementasyonu yaparken veya katmanlar arası geçiş yaparken kullanıyoruz
        //ortak özellikleri tanımlıyoruz
        //interfaces yazılırken dönüş değeri(int), ismi(Id),özelliği({ get; set; }) şeklinde yaılır | methodlar için de böyle kullanıyoruz
        int Id { get; set; }//kısayol olarak prop yazıp çift tab yapıyoruz, sonra gelen yerde public'i siliyoruz
        string FirstName { get; set; }
        string LastName { get; set; }
        //tanımlanan bu özellikler, implemente edilen class'ın içinde belirtmek zorundasın
    }
    //aşağıdaki iki class somut nesnedir
    class Customer : IPerson //Iperson demekle, IPerson'da tanımlanan her şeyi burada da görebiliriz
    {
        //interface'de yer alan özellikleri burada public olarak yazmamız yeterli
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }//müşterinin adresi
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; } //öğrencinin bölümü
    }

    //yeni bir grup eklediğimizde programı bozmak durumunda kalmıyoruz
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; } //çalışanın bölümü
    }

    //Manager ifadesi genelde iş katmanları için kullanılır
    class PersonManager
    {
        //kişiyi veritabanına ekleyecek operasyonu yapıyoruz
        //public void Add(Customer customer) //Add(...) => ekleme işleminde bana bir müsteri ver, müşteri tipinde bir parametre ver | anlıyoruz ki bir nesne de parametre olabilir
        //Ancak yukarıdaki gibi yapmıyoruz, çünkü interface ortak veri tutar, eğer hem müşteriye hem de öğrenciye bağlanmak istiyorsak interface'yi parametre olarak göndermeliyiz
        public void Add(IPerson person)
        {
            Console.WriteLine("Kişi eklendi: " + person.FirstName + " " + person.LastName);
        }
    }
}
