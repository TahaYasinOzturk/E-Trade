using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.DTO
{
    public class FoodsDTO
    {
        // iki tabloyu bir araya toplayacağız
        //istediklerimizi almak sadece bunları göstermek icin yaptık.luzumsuz olanları göstermemek icin yaptık.
        public Guid FoodId { get; set; }
        public string FoodName { get; set; }
      
    }
}
