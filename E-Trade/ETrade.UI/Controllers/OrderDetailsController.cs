using ETrade.Ent;
using ETrade.Ent
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
	public class OrderDetailsController : BaseController
	{
		private readonly OrderDetails orderDetails;

		public OrderDetailsController(IUow uow, OrderDetails orderDetails) : base(uow)
		{
			this.orderDetails = orderDetails;
		}

		public IActionResult List(Guid Id)
		{
            return View(uow.orderDetailRepository.GetOrderDetails(Id));
        }
	}
}
