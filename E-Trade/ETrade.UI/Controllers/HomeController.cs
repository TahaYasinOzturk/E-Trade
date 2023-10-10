using ETrade.Ent;
using ETrade.UI.Models;
using ETrade.UI.Session;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ETrade.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Users user;

        public HomeController(ILogger<HomeController> logger , Users user)
        {
            _logger = logger;
            this.user = user;
        }

        public IActionResult Index()
        {
            //authocontrollerda public IActionResult Register(Users u)
            //SessionHelper.SetObjectAsJson(HttpContext.Session, "user", u);
            //u = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user"); yazdık geldik

            ////Session.SessionHelper.LoginUser = SessionHelper.GetObjectFromJson<Users>(HttpContext.Session, "user");
            //Session.SessionHelper.LoginUser = user;
            ////Session.SessionHelper.LoginUser.isAdmin == true aynı şey alttaki ile
            //if (Session.SessionHelper.LoginUser.isAdmin)
            //{
            //    return View("Admin", "Admin");
            //}
           return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}