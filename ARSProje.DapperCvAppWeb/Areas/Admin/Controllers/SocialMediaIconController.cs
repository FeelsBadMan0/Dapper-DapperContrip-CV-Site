using ARSProje.DapperCvAppDTO.DTOs.SocialMedioIconDto;
using ARSProje.DapperCvAppEntities.Concrate;
using ARSProjeDapperCvAppBusiness.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ARSProje.DapperCvAppWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SocialMediaIconController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly ISocialMediaIconService _socialMediaIconService;
        private readonly IMapper _mapper;


        public SocialMediaIconController(ISocialMediaIconService socialMediaIconService, IAppUserService appUserService, IMapper mapper)
        {
            _socialMediaIconService = socialMediaIconService;
            _appUserService = appUserService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "sosyalmedya";
            var user = _appUserService.FindByName(User.Identity.Name);
            return View(_mapper.Map<List<SocialMediaIconListDto>>(_socialMediaIconService.GetByUserId(user.Id)));
        }

        public IActionResult Add()
        {
            TempData["active"] = "sosyalmedya";
            return View(new SocialMediaIconAddDto());
        }

        [HttpPost]
        public IActionResult Add(SocialMediaIconAddDto model)
        {
            TempData["active"] = "sosyalmedya";
            if (ModelState.IsValid)
            {
                var user = _appUserService.FindByName(User.Identity.Name);
                model.AppUserId = user.Id;

                _socialMediaIconService.Insert(_mapper.Map<SocialMediaIcon>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");

            }
            return View(model);

        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "sosyalmedya";
            return View(_mapper.Map<SocialMediaIconUpdateDto>(_socialMediaIconService.GetById(id)));

        }

        [HttpPost]
        public IActionResult Update(SocialMediaIconUpdateDto model)
        {
            TempData["active"] = "sosyalmedya";
            if (ModelState.IsValid)
            {
                var user = _appUserService.FindByName(User.Identity.Name);
                var social = _socialMediaIconService.GetById(model.Id);

                social.AppUserId = user.Id;
                social.Icon = model.Icon;
                social.Link = model.Link;

                _socialMediaIconService.Update(social);
                TempData["message"] = "Güncelleme işlemi başarılı";

                return RedirectToAction("Index");

            }
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            TempData["active"] = "sosyalmedya";
            var social = _socialMediaIconService.GetById(id);
            _socialMediaIconService.Delete(social);
            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }
    }
}
