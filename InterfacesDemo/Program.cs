using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burada yapılan işlem interface'leri doğru planlamak
            //SOLID yazılım geliştirme prensiplerinden I harfini gerçekleştirmiş olduk | Interface Segregation

            IWorker[] workers = new IWorker[3]
            {
            new Manager(),
            new Worker(),
            new Robot()
            };

            foreach (var worker in workers)
            {
                //Bütün worker'ları aynı anda çalıştırmak istediğimde bütün worker'ları gezip hepsine çalış emri vermiş oluyoruz
                worker.Work();
            }

            IEat[] eats = new IEat[2] //çalışanlara yemek izni vereceğiz
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats) //çalışanlara hadi yemek yiyin dediğimiz zaman sadece ilgili interface'i implemenate eden nesnelerimi çağırmış oluyoruz 
            {
                eat.Eat();
            }
        }
    }
    //Senaryo: Bir şirkette çeşitli çalışanlar mevcut, bunlar işçiler, yöneticiler ve robotlar
    //interface IWorker //bunlar birer işçidirler
    //{
    //    void Work();//Bütün çalışanlar çalışır
    //    void Eat(); //Bütün çalışanlar yemek yer
    //    void GetSalary(); //Bütün çalışanlar maaş alır
    //}
    //Interface'lerin güzel bir yönü de birden fazla Interface tanımlayıp bunları ihtiyaca göre kullanmak
    //aşağıda şuan tek bir operasyon tanımlandı ama farklı operasyonlar varsa herbir interface için, o interface'in içine tanımlanabilir
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    //bir class birden fazla Interfae'i imlemente edebilir


    //Yönetici
    class Manager : IWorker, IEat, ISalary //Yönetici, bir işçidir, aynı zamanda yemek yer ve aynı zamanda maaş alır
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        //public void Eat()
        //{
        //    throw new NotImplementedException();
        //}

        //public void GetSalary()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Work()
        //{
        //    throw new NotImplementedException();
        //}
        
    }

    //Normal Çalışan
    class Worker : IWorker, IEat, ISalary 
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
        //public void Eat()
        //{
        //    throw new NotImplementedException();
        //}

        //public void GetSalary()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Work()
        //{
        //    throw new NotImplementedException();
        //}
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
        ////Interface'te belirtilen 2 kısım robot için geçerli değildir, bazıları trick yöntemle içini boş bırakıyor, ancak görüntü hoş değil | ör, eat geliyor ama hiçbir şey yapmıyor
        //public void Eat()
        //{

        //}

        //public void GetSalary()
        //{

        //}

        //public void Work()
        //{
        //    throw new NotImplementedException();
        //}

    }







}
