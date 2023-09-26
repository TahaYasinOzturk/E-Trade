using ETrade.Core;
using ETrade.Dal;
using ETrade.Ent;
using ETrade.Rep.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Concretes
{
    public class OrderRepository : BaseRepository<Orders>, IOrderRepository
    {
        public OrderRepository(Context context) : base(context)
        {

        }

        public List<Orders> GetOrders(Guid Id)
        {
           //gönderilmemişler gelecek.
           return List().Where(x => x.UserId == Id && x.isDelivered == false).ToList();
           
             
        }
    }
}
