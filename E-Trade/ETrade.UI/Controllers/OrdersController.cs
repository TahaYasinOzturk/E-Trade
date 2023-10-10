using ETrade.Ent;
using ETrade.UI.Session;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class OrdersController : BaseController
    {
        private readonly Orders orders;

        public OrdersController(IUow uow, Orders orders) : base(uow)
        {
            this.orders = orders;
        }
        public IActionResult List()
        {
            SessionData.LoginUser = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
            return View(Uow.orderRepos.GetOrders(SessionData.LoginUser.UserId));
        }
        public IActionResult Create()
        {
            orders.isDelivered = false;
            orders.CreatedDate = DateTime.Now;
            orders.TotalPrice = 0;
            orders.LastUpdated = DateTime.Now;
            SessionData.LoginUser = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
            orders.UserId = SessionData.LoginUser.UserId;
            orders.ShippingAddress = SessionData.LoginUser.ShipAddress;
            Uow.orderRepos.Add(orders);
            Uow.Commit();
            return RedirectToAction("List", "OrderDetails", new { Id = orders.OrderId });
        }
    }
}
