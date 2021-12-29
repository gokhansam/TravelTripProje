using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sinifler
{
    public class BlogYorum
    {
        //system.collections.Generic sınıfına ait IENUMARABLE formatında koleksiyon olarak çekmeye yarar.
        //yani burada bir view içerisine birden fazla tablodan değer çekmeye yarar.
        public IEnumerable<Blog> Deger1 { get; set; } // blog tablosundan bir property oluşturmaya yarıyor.
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}