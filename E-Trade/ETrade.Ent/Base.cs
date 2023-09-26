using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Ent
{
    public class Base
    {
        //[Key] // base classlarda key olur öyle olmak zorunda
        //public Guid Id { get; set; }

        public DateTime LastUpdated { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
