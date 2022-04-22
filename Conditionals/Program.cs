using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //şart blokları
            var number = 20;
            //if (number == 10) //eğer sayı 10 ise
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10");
            //}
            //single line if
            //number==10 doğru mu?, doğru ise "Number is 10", değilse "Number is nort 10"
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            Console.WriteLine("----------");

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }
            //else olduğunde en az bir tanesi çalışacak

            //switch bloğuyla çalışmak, çok sık kullanılmaz
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}

            ////Demo çoklu şartlarla çalışmak
            ////&&: ve anlamına gelir, iki şart birden sağlamalıdır
            ////||: veya anlamına gelir, bir şart ısağlaması yeterlidir. pipe(boru)dan gelir
            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if (number > 110 && number <=200)
            //{
            //    Console.WriteLine("number is between 100-200");
            //}
            //else if(number>200 || number<0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}

            //iç içe if blokları
            if (number < 100)
            {
                if (number >= 90 && number < 95)
                {

                }
                else
                {

                }
                if (number >= 50 || number <= 60)
                {
                    if (number>55)
                    {

                    }
                }
                else
                {

                }
            }

            Console.ReadLine();//uygulama kapanmasın diye


        }
    }
}
