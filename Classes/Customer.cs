using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Bir müşterinin özelliklerini tutmak için kullandığımız nesnedir
    class Customer
    {
        //aşağıdakiler property'lerdir
        //müsterinin özelliklerini tutmak için de property'lerden, class'lardan yararlanabiliyoruz
        public int Id { get; set; }
        //public string FirstName;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
