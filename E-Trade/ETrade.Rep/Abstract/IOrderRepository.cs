﻿using ETrade.Core;
using ETrade.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Abstract
{
    public interface IOrderRepository : IBaseRepository<Orders>
    {
        List<Orders> GetOrders(Guid Id);    
    }
}
