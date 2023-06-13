using ARSProje.DapperCvAppWeb.Models;
using ARSProjeDapperCvAppBusiness.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ARSProje.DapperCvAppWeb.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAppUserService _appUserService;
        public AuthController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public IActionResult Login()
        {
            return View(new AppUserLoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (_appUserService.CheckUser(model.UserName, model.Password))
                {
                    //giriş başarılı

                    var claims = new List<Claim>
{
    new Claim(ClaimTypes.Name, model.UserName),
    new Claim(ClaimTypes.Role, "Admin"),
};

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {


                        IsPersistent = model.RememberMe

                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return RedirectToAction("Index", "Home", new { @area = "Admin" });
                }
                ModelState.AddModelError("", "Kullanıcı adı veya parola hatalı");
            }
            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home", new { @area = "" });
        }
    }
}
