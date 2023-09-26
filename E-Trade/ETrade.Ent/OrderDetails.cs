using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
    public class OrderDetails : Base
    {
        //[Key]
        //[key] kaldırabiliriz composite key yapıcaz.
        //composiste order 1 order 2 diyep 2 key koyurysun composite key oluyor.

        public Guid OrderId { get; set; }
        public Guid FoodId { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }

        [ForeignKey(nameof(OrderId))]
        //[ForeignKey("OrderId")] // the same with above
        public Orders Orders { get; set; }

        [ForeignKey(nameof(FoodId))]
        public Foods Foods { get; set; }


        // bu aşağıdaki kompozit key oluşturmaya yarıyor
        // context içine yazılan OnModelCreating fonksiyonu yerine bunu kullanabiliriz
        //[Key]
        //[Column(Order =1)]
        //public Guid OrderId { get; set; }

        //[Key]
        //[Column(Order = 2)]
        //public Guid FoodId { get; set; }
    }
}
