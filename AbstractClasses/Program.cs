using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
    //Abstract'lar da birer class'tır | Interface'ler gibi değil
    //Interface ile virtual methodların birleşimi gibi düşünülebilinir
    //Tamamen Inheritance amacıyla kullanılır
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface'ler gibi Abstract class'ları da new'leyemiyoruz
            DataBase dataBase = new Oracle();
            dataBase.Add();
            dataBase.Delete();

            DataBase dataBase1 = new SqlServer();
            dataBase1.Add();
            dataBase1.Delete();

            Console.ReadLine();
        }
    }

    abstract class DataBase //Bastract class'lar birer Inheritance'tır
    {
        //Ekleme bütün veritabanlarında aynıdır
        //buna tamamlanmış methodlar denir
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        //Silme işlemi her veritabanı için farklıdır | nomalde böyle bir şey yok tamamen senaryo oluşturuyoruz
        //buna da tamamlanmamış methodlar denşr
        public abstract void Delete();
        //Abstract dediğimiz şey içi dolu olmayan virtual methoddur
        //içi dolu olmadığında nherkesin ayrı ayrı implemente etmesi gerekir
    }

    class SqlServer : DataBase
    {
        public override void Delete() //verilen uyarıdan implemente edildiğinde
                                      //sadece delete geldi ve override olrak geldi
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
