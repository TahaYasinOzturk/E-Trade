using ETrade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UOW
{
    public interface IUow
    {
        // değişkenler

        public ICategoryRepository categoryRepository { get; }
        public IFoodRepository foodRepository { get; }
        public IOrderDetailRepository orderDetailRepository { get; }
        public IOrderRepository orderRepository { get; }
        public IPropertyRepository propertyRepository { get; }
        public IUserRepository userRepository { get; }

        void Commit();
    }
}
