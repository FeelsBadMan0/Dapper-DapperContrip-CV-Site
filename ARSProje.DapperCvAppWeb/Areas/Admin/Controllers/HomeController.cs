using ARSProje.DapperCvAppDTO.DTOs.AppUserDtos;
using ARSProje.DapperCvAppWeb.Models;
using ARSProjeDapperCvAppBusiness.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace ARSProje.DapperCvAppWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private IAppUserService _appUserService;

        public HomeController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            TempData["active"] = "bilgilerim";

            var user = _appUserService.FindByName(User.Identity.Name);
            var appUserUpdateModel = new AppUserUpdateModel
            {
                Email = user.Email,
                Address = user.Address,
                FirstName = user.FirstName,
                Id = user.Id,
                LastName = user.LastName,
                ImageUrl = user.ImageUrl,
                PhoneNumber = user.PhoneNumber,
                ShortDescription = user.ShortDescription

            };
            return View(appUserUpdateModel);
        }

        [HttpPost]
        public IActionResult Index(AppUserUpdateModel model)
        {
            TempData["active"] = "bilgilerim";
            if (ModelState.IsValid)
            {
                var updatedAppUser = _appUserService.GetById(model.Id);
                if (model.Picture != null)
                {
                    var imgName = Guid.NewGuid() + Path.GetExtension(model.Picture.FileName);
                    var path = Directory.GetCurrentDirectory() + "/wwwroot/img/" + imgName;
                    var stream = new FileStream(path, FileMode.Create);
                    model.Picture.CopyTo(stream);
                    updatedAppUser.ImageUrl = imgName;
                }
                updatedAppUser.FirstName = model.FirstName;
                updatedAppUser.LastName = model.LastName;
                updatedAppUser.Email = model.Email;
                updatedAppUser.Address = model.Address;
                updatedAppUser.PhoneNumber = model.PhoneNumber;
                updatedAppUser.ShortDescription = model.ShortDescription;

                _appUserService.Update(updatedAppUser);

                TempData["message"] = "İşeminiz başarı ile gerçekleşti";

                return RedirectToAction("Index");

            }
            return View(model);
        }

        public IActionResult ChangePassword()
        {
            var user = _appUserService.FindByName(User.Identity.Name);


            TempData["active"] = "sifre";
            return View(new AppUserPasswordDto
            {
                Id = user.Id,
            });
        }

        [HttpPost]
        public IActionResult ChangePassword(AppUserPasswordDto model)
        {
            TempData["active"] = "sifre";
            if (ModelState.IsValid)
            {
                var updateUser = _appUserService.FindByName(User.Identity.Name);
                updateUser.Password = model.Password;
                _appUserService.Update(updateUser);
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            return View(model);
        }
    }
}
