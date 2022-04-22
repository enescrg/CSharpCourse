using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler
            //veri kümesini dolaşmak için kullanılır

            ////for döngüsü
            ////int i =0      sayaç,başlangıç değeridir
            ////i<=100        şart,hangi şarta kadar dönecek
            ////i++           bir dönüş bittiğinde bir sonraki dönüşte ne yapması gerektiğini belirtir.
            ////i+=2 ile i=+2 aynı anlama gelmektedir
            //for (int i = 0; i <= 100; i = i + 5)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("----------");

            ////100'den 0'a kadar geriye doğru sayma
            //for (int i = 100; i >= 0; i = i - 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("For Loop Finished!");

            ////!!ufak trickler
            ////alttaki for döngüsünü kısaca method haline getirmek için
            ////edit>refactor>extract method diyoruz
            //for (int i = 100; i >= 0; i = i - 2)
            //{
            //    Console.WriteLine(i);
            //}
            //ForLoop();

            //*************

            ////while döngüsü
            //int number = 100;
            //while (number >= 0)
            //{
            //    Console.WriteLine(number);
            //    //number--; tek tek azaltır, alttaki de ikili azaltır
            //    number = number - 2;
            //}
            ////alttakinde ise döngüden çıkarken en son kaldığı sayıdan bir sonraki sayıyı yazdırır
            //Console.WriteLine("Now Number is {0}",number);
            //Console.WriteLine("While Loop Finished!");

            ////!!ufak trickler
            ////alttaki while döngüsünü kısaca method haline getirmek için
            ////edit>refactor>extract method diyoruz
            ////int number = 100;
            ////while (number >= 0)
            ////{
            ////    Console.WriteLine(number);
            ////    number = number - 2;
            ////}
            ////Console.WriteLine("Now Number is {0}", number);
            //WhileLoop();

            //*************

            ////Do-While döngüsü
            ////şart sağlanmasa bile mutlaka döngü bir defa çalışacaktır
            ////bir connection'ı, data yoksa kapatmat için kullanılabilinir
            ////ör, eve geldik tüpü kapatmış mıyız diye kontrol ederkne ışığın da açık olduğunu görüyoruz ve kapatıyoruz
            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number>=0);
            //Console.WriteLine("Do-While Loop Finished!");

            ////!!ufak trickler
            ////alttaki do-while döngüsünü kısaca method haline getirmek için
            ////edit>refactor>extract method diyoruz
            //int number = 10;
            //do
            //{
            //    Console.WriteLine(number);
            //    number--;
            //} while (number >= 0);
            //Console.WriteLine("Do-While Loop Finished!");
            //DoWhileLoop();

            //*************

            ////ForEach döngüsü
            ////en çok kullanılan döngülerdendir
            ////dizi temelli dataların dolaşılması/iterate
            ////daha çok veritabanından bir tabloyu çekmek istediğimizde datayı gezmek için sıklıkla kullanırız
            //string[] students = new string[3] { "Engin", "Derin", "Salih" };
            ////students dizisi için takma isim oluşturuyoruz(student),
            ////böylece dizide herbir eleman student olmuş oluyor ve dönmeye başlıyor
            //foreach (var student in students)
            //{
            //    //foreach ile döndüğümüz elemanları döngü içerisinde değiştiremiyoruz
            //    //student = "Ahmet";
            //    Console.WriteLine(student);
            //}

            ////!!ufak trickler
            ////alttaki do-while döngüsünü kısaca method haline getirmek için
            ////edit>refactor>extract method diyoruz
            //string[] students = new string[3] { "Engin", "Derin", "Salih" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //ForEachLoop();

            //*************

            //asal sayılar | örnek çalışma
            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }



            Console.ReadLine();
        }
        //bool asalsa true, asal değilse false döndürsün
        //IsPrimeNumber: asal sayılar mı | boolean olduğu için genelde başında is ifadesi kullanırıız
        private static bool IsPrimeNumber(int number)
        {
            bool result = true; //sonucu tutmak için
            for (int i = 2; i < number-1; i++)
            {
                //%: bölme için modu kullanırız
                if (number%i==0)//sayının i'ye bölümünden kalan 0'sa
                {
                    //eğer şart sağlanırsa if'in içine girecek ve sonucu false olarak döndürecek
                    result = false;
                    i = number; //bunu kullanarak performans arttırır.
                    //çünkü if bloğu bir defa çalıştığında eğer sonuç false olarak dönmüşse(yani if bloğuna girmişse)
                    //orada if bloğunu kesecek daha fazla şart denemeyecek
                    //bunun dışında break,continue ifadeleri de kullanılabilinir
                    
                }
            }
            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 0);
            Console.WriteLine("Do-While Loop Finished!");
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number = number - 2;
            }
            Console.WriteLine("Now Number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("For Loop Finished!");
        }
    }
}
