using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly CategoriesModel model;

        public CategoriesController(IUow Uow, CategoriesModel model ) : base(Uow)
        {
            this.model = model;
        }
        public IActionResult List()
        {            
            return View(uow.categoryRepository.GetCategories());
        }
        public IActionResult Create()
        {
            model.Head = "Yeni Giriş";
            model.Text = "Kaydet";
            model.Class = "btn btn-primary";
            

            //model.Categories = uow.categoryRepository.Find(Id);
            //uow.categoryRepository.GetCategories()
            return View("Crud",model);
        }
        [HttpPost]
        public IActionResult Create(CategoriesModel m)
        {
            uow.categoryRepository.Add(m.Categories);         
            uow.Commit();
            return RedirectToAction("List");
            
        }
        public IActionResult Update(Guid Id)
        {
            model.Categories = uow.categoryRepository.Find(Id);

            model.Head = "Güncelleme";
            model.Text = "Güncelle";
            model.Class = "btn btn-success";

            
            
            return View("Crud", model);
        }
        [HttpPost]
        public IActionResult Update(CategoriesModel m)
        {
            uow.categoryRepository.Update(m.Categories);
            uow.Commit();
            return RedirectToAction("List");

        }
        public IActionResult Delete(Guid id)
        {
            //var cat = Uow.catRepos.Find(id);
            //return View(cat);

            uow.categoryRepository.Delete(uow.categoryRepository.Find(id));
            uow.Commit();
            return RedirectToAction("List");
        }
        //public IActionResult Delete(Guid Id)
        //{

        //    model.Categories = uow.categoryRepository.Find(Id);
        //    model.Head = "Silme işlemi";
        //    model.Text = "Sil";
        //    model.Class = "btn btn-danger";

        //    //uow.categoryRepository.GetCategories()
        //    return View("Crud", model);
        //}
        //[HttpPost]
        //public IActionResult Delete(CategoriesModel m)
        //{
        //    uow.categoryRepository.Delete(uow.foodRepository.Find(m));
        //    //uow.categoryRepository.Delete(m.Categories);
        //    uow.Commit();
        //    return RedirectToAction("List");
        //}

    }
}
