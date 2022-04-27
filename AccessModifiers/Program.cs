using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
    //AccessModifiers : Erişim belirleyicileri
{
    class Program
    {
        static void Main(string[] args)
        {
            //private en alt seviyede
            //protected Inheritance seviyesinde kullanılmasıyla privetnin üst seviyesinde
            //internal proje içersinde istenilen noktada kullanılmasıyla protected'in üst seviyesinde
            //public refrans verldiğinde farklı projelerden de erişim sağlar

            //her şeyi public yapmak isteyebiliriz, ancak programcıyı yanlış yönlendirmemek, kodun okunurluluğunu arttırmak ciddi meselelerdir
            //Yazılım geliştirmede en temel kurallardan bir tanesidir: Least Privilege
            //Bir şeyin neye ihtiyacı varsa minimumda, o minimumu tanımlamalısın, daha fazlasına ihtiyaç olduğu zaman üst seviyeye çıkartılır

            //Üst seviyeli bir class private olamaz, çünkü onu kullanacak bir ortam olamaz
            //iç içe olan class'lar private olabilir
            //protected de olamaz | ya Internal ya da public olur
        }
    }

    class Customer
    {
        int id; //bu şekilde yazıldığında default olarak Private olur
                //ancak bir üst blokta tanımlanana alt blokta erişim sağlanabilir
        public void Save() //kaydetme methodu
        {
            id = 1; //private belirleyici sadece tanımlandığı blok içerisinde geçerlidir
                    //class içerisinde, method içinde, if bloğu içerisinde tanımlandıysa sadece o blokta kullanılabilinir
        }
        public void Delete()
        {

        }

        //protected'i class seviyesinde kullanırız
        //farklı class'lar eğer protected'in tanımlı olduğu class'ı Inheritance ediyorsa orada da kullanılabilinir
        protected int Id2 { get; set; } //tanımlandığı blok içerisinde her yerde geçerlidir
    }

    class Student:Customer
    {
        public void Save2() 
        {
            Id2 = 2; 
        }
    }

    //Internal belirleyicisine sahip class'lar bulunduğu projede(buna Assembly diyoruz) 
    //bu asembly içerisinde referans ihtiyacı olmadan kullanabiliyoruz
    //class Course //Bir class'ın default'u Internal'dır
    public class Course//public yaptık çünkü AccessModifiersDemo projesinde kullanmak istiyoruz
    {
        public string Name { get; set; }

        private void NestedClass()//bu class sadece bir üst class içerisinde kullanılabilinir
        {

        }
    }
}
