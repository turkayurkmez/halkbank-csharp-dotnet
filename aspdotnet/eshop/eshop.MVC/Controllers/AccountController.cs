using eshop.MVC.Models;
using eshop.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace eshop.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Login(string? gidilecekSayfa)
        {
            UserLoginViewModel model = new UserLoginViewModel();
            model.ReturnUrl = gidilecekSayfa;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLogin)
        {
            if (ModelState.IsValid)
            {
                var user = userService.ValidateUser(userLogin.UserName, userLogin.Password);
                if (user != null)
                {
                    //Çereze, kimliğini kanıtladığını bilgisini (kullanıcı adı gibi detaylar ile birlikte)
                    //yazdır.

                    var claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.FullName),
                        new Claim(ClaimTypes.GivenName, user.UserName),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role),
                    };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    if (!string.IsNullOrEmpty(userLogin.ReturnUrl) && Url.IsLocalUrl(userLogin.ReturnUrl))
                    {
                        return Redirect(userLogin.ReturnUrl);
                    }

                }
                ModelState.AddModelError("login", "Kullanıcı adı veya şifre yanlış!");
            }
            return View();

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult ErisimEngellendi()
        {
            return View();
        }
    }
}
