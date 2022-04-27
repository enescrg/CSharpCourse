using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance //Kalıtım, miras anlamında kullanılabilinir
{
    //Interface'ler de birar Inheritance örneği gibi çalışırlar, ancak Inheritance değillerdir, birer implementasyondur
    //yeni nesil dillerde Interface'ler, Inheritance gibi kullanılan senaryolar mevcuttur
    
    //Interface mi kulanılmalı yoksa Inheritance mi?
    //eğer kulandığımız senaryo buradaki gibiyse Interfaces kullanılması tavsiye edilir
    //Abstract sınıflar Inheritance class'ları açısından önemli bir yer teşkil eder
    //Temel anlamda Interface kullanabiliyorsak, Inheritance'a ihtiyacımız olduğunu düşünmüyorsak, zorunlu hissetmiyorsak Interface'lerden yürümek tavsiye edilir

    class Program
    {
        static void Main(string[] args)
        {
            ////alttaki kullanım aynen Student için de geçerlidir 
            //Customer customer = new Customer();
            //customer.City = "Van";

            //Customer de, Student de, Person tek başına da bir person'dır
            //Bu yüzden person diye Array oluşturup diğer class'lara erişim sağlayabiliyoruz
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Enes"
                },//tanımları süslü parantez içerisinde yapıyoruz
                new Student
                {
                    FirstName = "Musab"
                },
                //üsttekileri new'lerken Person önerisini de yapıyor | çünkü Interface tek başına bir anlam ifade etmezken
                //Inheritance class'ı tek başına veya Inheritance verdiği noktada da anlam ifade ediyor
                new  Person
                {
                    FirstName="Salih"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            Console.ReadLine();
        }
    }

    class Person //Interface olmadığı için I ile başlamadık
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //class Person2
    //{

    //}
    //class Customer:Person,Person2 diyemeyiz, bir kişinin bir tane babası olur
    //Bir nesneyi sadece bir defa inheritance alabiliriz ama birden fazla imlemente edebilriz

    interface IPerson
    {

    }
    //class Customer :Person,IPerson diyebiliriz, çünkü bir nesne birden fazla Interface implemente edebilir
    //Burada önemli olan önce Inheritance yazılır sonra Interface'ler yazılır

    class Customer :Person 
        //Customer'in ebeveyni Person'dır | Customer, Person'dan meydana gelmiş bir nesne gibi düşünülebilinir
        //Customer'in babası Person'dır
    {
        //Bir çocuk ebeveyninin özelliklerini aynen almak zorunda değildir, farklı özellikleri olabilir
        public string City { get; set; }
    }

    class Student:Person
    {
        public string Department { get; set; }
    }
}
