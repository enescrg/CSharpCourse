using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class CourseManager
    {
        public void Add()
        {
            //Course ihtiyacım olduğunda yapmam gereken hiçbir şey yok, direk kullanabiliyoruz
            //çünkü Program.cs'de Internal belirleyicisiyle kullanılmıştı | diğer class'larda da default olarak Internal belirleyicisi bulunmaktadır
            //ayrıca aynı Assemby'de bulunması gerekmektedir
            Course course = new Course();
        }
    }
}
