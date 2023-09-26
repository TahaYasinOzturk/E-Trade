using ETrade.Ent;
using ETrade.UI.Session;
using ETrade.UOW;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class AuthController : BaseController
    {
        private readonly Users user;

        public AuthController(IUow uow, Users user) : base(uow)
        {
            this.user = user;
        }

        public IActionResult Register()
        {            
            return View(user);
        }
        [HttpPost]
        public IActionResult Register(Users u)
        {

            //sessionhelper yaptık
            uow.userRepository.Register(u);
            uow.Commit();

           // SessionHelper.SetObjectAsJson(HttpContext.Session, "user", u);
            //u = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View(user);
        }
        [HttpPost]
        public IActionResult Login(Users u)
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "user",u); //key "user"
            
            return RedirectToAction("Index","Home");
        }

    }
}
