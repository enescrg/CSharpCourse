using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir projede başka bir projedeki nesneyi kullanabilmek için
            //bulunduğun projede references üzerinde Add referance deyip, project>solution ardından referans almak istediğimiz projeyi seçiyoruz
            //daha sonra sayfanın en üstünde using ifadeler bulunmakta
            //oraya referans almak istediğimiz projeyi yazıyoruz | using AccessModifiers;
            //son olarak almak istediğimiz nesne varolduğu class'ın public olması gerekir
            Course course = new Course();
            course.Name = "Enes";
        }
    }
}
