using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal //Dal: Data Access'ten geliyor, veritabanı işlerini yapmak için kullanacağımız sınıf | Insert, Update, Delete
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    //yeni bir veritabanı eklendiğinde programımı bozmak durumunda kalmayacağız
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
    }
    class CustomerManager
    {
        //parametre olarak ınterface'i vereiğimizde gelecekte farklı veritabanıyla çalışılırsa kolaylıkla geçiş yapılabilinir
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

    }
}
