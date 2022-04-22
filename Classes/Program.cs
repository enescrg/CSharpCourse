using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //temel olarakyapmak istediğimiz işleri gruplara ayırmak, o grup üzerinden işlermleri yapmak ve kolaylıkla bu gruba ulaşmak için class'ları kullanırız
            //bir class'ı kullanmak için onun bir örneğini oluşturmak gerekir
            //bir class ismi oluşturulurken pascal keys kullanılır | ama bir örneği oluşturulurken camel keys kullanılır
            CustomerManager customerManager = new CustomerManager(); //aslında bir referansını oluşturmuş oluyoruz
            customerManager.Add();
            customerManager.Update();

            //hangi nesneyle çalışacaksam o nesneye ait classı, örneğini oluşturuyoruz, sonra içindeki methodları çağırabiliyoruz
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            //Bir class, o class'la ilgili methodları barındırır

            //classları ayrı bir dosya olarak da tutabiliyoruz
            //project>Add>Class..

            //class'lar içinde property tanımlamak
            //Bir class'ın property'sini eşitlediğimizde onu set etmiş oluyoruz
            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Enes";
            customer.LastName = "Çirağ";
            //yukarıda kullanabildiğimiz gibi aşağıdaki şekilde de barındırabiliyoruz
            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Engin",
                LastName = "Demiroğ"
            };
            //Bir class'ın property'sini de okuduğumuzda ise buna get diyoruz| | Burada bir eşitleme yoktur sadece okuyoruz
            Console.WriteLine(customer2.FirstName);


            Console.ReadLine();
        }
    }
    //Bu classları burada yazabildiğimiz gibi yeni bir dosyada da yazabiliriz, o şekilde dah kullanışlı olacaktır
    //iki class'ı yeni dosyalara taşıdık

    ////Müşteri tönetimi classı
    //class CustomerManager
    //{
    //    //birden fazla method ekleyebiiliriz
    //    public void Add()
    //    {
    //        Console.WriteLine("Customer Added!");
    //    }

    //    public void Update() 
    //    {
    //        Console.WriteLine("Customer Updated!"); 
    //    }
    //}

    ////Ürün yönetimi classı
    //class ProductManager
    //{
    //    //birden fazla method ekleyebiiliriz
    //    public void Add()
    //    {
    //        Console.WriteLine("Product Added!");
    //    }

    //    public void Update()
    //    {
    //        Console.WriteLine("Product Updated!");
    //    }
    //}
}
