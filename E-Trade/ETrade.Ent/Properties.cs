﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
    public class Properties : Base
    {
        [Key]
        public Guid PropertyId { get; set; }
        public Guid FoodId { get; set; }
        public string PropertyName { get; set; }
        public decimal UnitPrice { get; set; }

        //1e cok olacak
        [ForeignKey(nameof(FoodId))]
        public Foods Foods { get; set; }
    }
}
