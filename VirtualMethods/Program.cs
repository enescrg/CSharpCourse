using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
    //Inheritance kapsamındadır | Ne zaman Inheritance ne zaman Interface kullanacağımızla ilgilki fikir veriyor olacak
    //aşağıda yapılan uygulamayı Interface ile yapamayız
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //VirtualMethods'da mantık, bir class mevcut ve bu class içerisinde çeşitli operasyonlar yapıyoruz
    class DataBase //veritabanı işleri yapılacak class
    {
        //Bu kapsamda DataBase operasyonlarını implemente etmemiz gerekiyor
        //ikisine de virtual yazılması zorunlu değildir sadece bir tanesine yazılması yeterlidir
        //virtual yapılan operasyonlar, Inheritance alan class'larda operasyon değiştirilmezse(override edilmezse) Inheritance edilen class'ın operasyonu kullanılır
        public virtual void Add()
        {
            Console.WriteLine("Added by default"); //default ekleme işlemi yapıldı
        }
        //Inheritance eilen operasyonlar birçok ortamda aynıysa bu şekilde(virtual keyword ile) yazılır
        //ama bazen değişkenlik gösterebilir, ezebiliriz dersek virtual veririz
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    //Birçok veritabanında yapılan işlemler çoğu zaman aynıdır
    class SqlServer:DataBase //SqlServer için DataBase'in Add ve Delete'ini kullanabilirsiniz anlamına gelir
    {
        //virtual yapıldığı için burada operasyonu değiştirmek istediğimizde override etmemiz gerekecek
        public override void Add() //override dediğimizde DataBase içerisinde yer alan virtual keyword'ı ile yazılmış operasyonlar eglir
        {
            Console.WriteLine("Added by Sql Code"); //Sql Kod ile eklendi
            //aşağıdaki kod otomatik geliyor, ve babası olan class'taki operasyonu aynen alıyor, bu yüzden yukrıda yeni kodlar yazıyoruz ki sqlserver'da farkli kod yazılmasını istiyoruz
            //base.Add(); //base denilen şey, sqlserver'ın temeli yani Inheritance alınan class'ı anlamına gelir(Bu da DataBase'dir)
            //base.Add(); kodu da aktif bırakılabilinir, böyle durumda hem yeni kod çalışır hem de temel kod çalışır
        }
    }

    class MySql:DataBase //burada virtual edilen kodu override etmediğimiz için temel kod çalışır
    {

    }
}
