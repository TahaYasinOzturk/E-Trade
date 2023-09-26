using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class PropertiesController : BaseController
    {
        
        private readonly PropertiesModel model;

        public PropertiesController(IUow Uow, PropertiesModel model) : base(Uow)
        {
            
            this.model = model;
        }
        
        public IActionResult List()
        {
            return View(uow.propertyRepository.GetProperties());
        }

        public IActionResult Create()
        {
            model.Text = "Save";
            model.Head = "New Properties";
            model.Class = "btn btn-outline-success my-2";
            //selet-option part, we need this func.
            model.FoodsDTOs = uow.foodRepository.GetFoods();
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Create(PropertiesModel m)
        {
            uow.propertyRepository.Add(m.Properties);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Update(Guid Id)
        {
            model.Head = "Update Properties";
            model.Text = "Update";
            model.Class = "btn btn-success";
            model.Properties = uow.propertyRepository.Find(Id);
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(PropertiesModel m)
        {
            //uow.propertyRepository.Update(uow.propertyRepository.Find(m.Properties.Id));
            uow.propertyRepository.Update(m.Properties);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(Guid Id)
        {
            //uow.propertyRepository.Delete(m.Properties);
            uow.propertyRepository.Delete(uow.propertyRepository.Find(Id));
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}
