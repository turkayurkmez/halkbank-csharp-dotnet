using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
