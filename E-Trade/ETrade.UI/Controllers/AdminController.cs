using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class AdminController : BaseController
    {

        private readonly BaseCrud model;

        public AdminController(IUow uow, BaseCrud model) : base(uow)
        {
            this.model = model;
        }

        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Foods()
        {
            return View(uow.foodRepository.GetFoods());
        }
        public IActionResult Properties()
        {
            return View(uow.propertyRepository.GetProperties());
        }
        public IActionResult Categories()
        {
            return View(uow.categoryRepository.GetCategories());
        }
    }
}
