using ETrade.Dal;
using ETrade.Rep.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.UOW
{
    public class Uow : IUow
    {
        // özellik olduğu için arrow kullanıldı metot değil property
        
        public ICategoryRepository categoryRepository { get; }
        public IFoodRepository foodRepository { get; }
        public IOrderDetailRepository orderDetailRepository { get; }
        public IOrderRepository orderRepository { get; }
        public IPropertyRepository propertyRepository { get; }
        public IUserRepository userRepository { get; }

        private readonly Context context;

        public Uow(Context context, 
            ICategoryRepository categoryRepository,
            IFoodRepository foodRepository,
            IOrderDetailRepository orderDetailRepository,
            IOrderRepository orderRepository,
            IPropertyRepository propertyRepository,
            IUserRepository userRepository)
        {
            // ctorda çağırmak yerine newleyebiliriz ama tavsiye edilmez
            this.context = context;
            this.categoryRepository = categoryRepository;
            this.foodRepository = foodRepository;
            this.orderDetailRepository = orderDetailRepository;
            this.orderRepository = orderRepository;
            this.propertyRepository = propertyRepository;
            this.userRepository = userRepository;
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
