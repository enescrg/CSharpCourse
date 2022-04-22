using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays:Diziler
            //aynı tipteki değişkenleri değerleri tek bir nokada yönetip,
            //ona hızlıca ulaşma,onu bir dmngüyle gezme ihtiyacında kullanılır
            //string: metinsel veri tipleri kullanılır. referans tiptir
            string[] students = new string[3];//3 elemanlı students arrayı
            students[0] = "Engin";//öğrenciler arrayının 0. elemanı "Engin"
            students[1] = "Derin";
            students[2] = "Salih";
            //üsttekini bu şekilde de yazabiliriz
            //new string[3] buradaki eleman sayısını da yazmayabiliriz
            string[] students2 = new string[3] {"Engin", "Derin", "Salih" };
            
            
            //diğer şekilde kullanımı
            string[] students3 = new[] {"Engin","Derin","Salih"};
            //new[] yazmadan da kullanılablinir, bir değişiklik olmayacaktır
            string[] students4 = { "Engin", "Derin", "Salih" };


            //foreach döngüsü bir Arrayı gezmek için kullanılır
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("---------");

            //Çok boyutlu diziler
            //Türkiyedeki bölgeler ve bölgelerdeki şehirleri tanımlıyoruz
            //5 satır 3 sütun anlamına gelir
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            //her satırı gezmem ve her sütunu yazmam gerekir
            //GetUpperBound(0): ilk satırın en üst değerini yakalamak için kullanılır
            //kaçıncı dimensions'ı gezmek istiyorsak o yazılır. Burada satır 0. dimensions, sütun da 1. dimensions'dır
            //i<=regions.GetUpperBound : döngüdeki bu kısımda <= kulanmalıyız çünkü elemanlar 0. dan başlar, hepsini almak için bunu yapmalıyız
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                //her satır için 3 tane de sütun gezmem gerekiyor, bunun için iç içe döngüden yararlanılır
                //bu sefer de 1. dimensions'ı gezmek için döngü kuruyoruz
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("-------");
            }

            Console.ReadLine();







        }
    }
}
