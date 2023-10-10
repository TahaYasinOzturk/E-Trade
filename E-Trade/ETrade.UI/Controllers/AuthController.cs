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
            var loginUser = uow.userRepository.Login(u);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "user", loginUser);
            SessionData.LoginUser = loginUser;
            if (SessionData.LoginUser.isAdmin == true)
            {
                return RedirectToAction("Admin", "Admin");

            }
            else
            {
                return RedirectToAction("Index", "Home");

            }

        }
        public IActionResult Logout()
        {
            Users users = null;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "user", user);
            SessionData.LoginUser = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
            return RedirectToAction("Index", "Home");

        }

    }
}
