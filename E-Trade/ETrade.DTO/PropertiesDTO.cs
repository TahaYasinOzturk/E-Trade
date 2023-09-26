using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.DTO
{
    public class PropertiesDTO
    {
        //çoka çok ilişki icin yaptık. property de coka coka ilişki var.
        //istediklerimizi almak sadece bunları göstermek icin yaptık. luzumsuz olanları göstermemek icin yaptık.
        public Guid Id { get; set; }
        public string PropertyName { get; set; }
    }
}
