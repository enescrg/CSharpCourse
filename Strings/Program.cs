using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //best practice: en iyi yoldan ilerleme

            //string metinsel verileri tutmak için kullanılan değişken tipidir
            //stringler birer char array'ıdır
            //Intro();
            
            //*************

            //string methodlarıyla çalışmak
            string sentence = "My name is Enes Çirağ"; //sentence: cümle
            
            var result = sentence.Length; //kaç karakterden oluştuğunu gösterir
            var result2 = sentence.Clone(); //ilgili string değerin bir referansını(clonunu) daha oluşturur
            //aşağıda sentence'ı değiştirsem de result2'yi değiştirememiş olurum
            //sentence = "My Name is Cat;)";
            //Console.WriteLine(result2);
            //Console.WriteLine(sentence);
            bool result3 = sentence.EndsWith("ğ"); //Bu cümle "ğ" ile bitiyor mu? sonuç bool şeklinde döndürür
            bool result4 = sentence.StartsWith("M"); //"M" ile başlıyor mu? cümle de yazılabilinir ("My name")
            var result5 = sentence.IndexOf("name"); //Bir stringde belirli bir ifadeyi arar ve kaçıncı karakterden başladığını gösterir | bulamadığında -1 döndürür
            var result6 = sentence.IndexOf(" "); //aradığı ifadeden birden fazla varsa bulduğu ilk ifadeyi alır
            var result7 = sentence.LastIndexOf("Ç"); //aramaya sondan başlar | saymaya ise baştan başlar yanı kaçıncı karakter olduğunu baştan sayarak gösterir
            var result8 = sentence.Insert(0,"Hello, " ); //bir cümleye veya bir string ifadeye başka bir metni,string ifadeyi yerleştirmeye yarar | (0,"Hello, ") 0. karakterden itibaren ifadeyi yerleştir
            var result9 = sentence.Substring(3); //metni parçalamak için kullanılır | 3. karakterden itibaren al anlamına gelir
            //var result9 = sentence.Substring(3,4); //3. karakterden itibaren 4 tane al
            var result10 = sentence.ToLower(); //bütün karakterleri küçk harfe dönüştürmeye yarar
            var result11 = sentence.ToUpper(); //bütün karakterleri büyük harfe çevirmeye yarar
            var result12 = sentence.Replace(" ","-"); //bir metin içerisinde belirli karakterleri değiştirmeye yarar | burada boşluk yerine "-" çizgi kullanmayı istedik
            var result13 = sentence.Remove(2); //bir metinden belirli bir indexten sonrasını atmak için kullanılır
            //var result13 = sentence.Remove(2,8); //2'den başlayıp 8 tane karakeri çıkar

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara"; //6 elemanlı bir dizidir
            //Console.WriteLine(city[0]);

            //foreach döngüsüyle city değişkeninin elemanlarını gezer
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            //stringleri toplamak mümkün, yan yana getirme sürecidir
            string city2 = "İstanbul";
            //string result = city + city2; bunu bellekte tutmaktansa
            //Console.WriteLine(result);
            //aşağıdaki gibi yaptığımızda bellekte yeni bir değişken tanımlamamış olacağız
            //String.Format() class'ını kullanarak yan yana yazdırabiliriz(toplayabiliriz)
            //class'lar büyük harfle başlar(String...)
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
