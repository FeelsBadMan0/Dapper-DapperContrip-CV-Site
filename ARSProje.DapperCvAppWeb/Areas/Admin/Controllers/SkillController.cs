using ARSProje.DapperCvAppDTO.DTOs.SkillDtos;
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
    public class SkillController : Controller
    {
        private readonly IGenericService<Skill> _skillGenericService;
        private readonly IMapper _mapper;

        public SkillController(IGenericService<Skill> skillGenericService, IMapper mapper)
        {
            _skillGenericService = skillGenericService;
            _mapper = mapper;
        }


        public IActionResult Index()
        {
            TempData["active"] = "yeteneklerim";
            return View(_mapper.Map<List<SkillListDto>>(_skillGenericService.GetAll()));
        }

        public IActionResult Add()
        {
            TempData["active"] = "yeteneklerim";
            return View(new SkillAddDto());
        }

        [HttpPost]
        public IActionResult Add(SkillAddDto model)
        {
            TempData["active"] = "yeteneklerim";
            if (ModelState.IsValid)
            {
                _skillGenericService.Insert(_mapper.Map<Skill>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "yeteneklerim";
            return View(_mapper.Map<SkillUpdateDto>(_skillGenericService.GetById(id)));


        }

        [HttpPost]
        public IActionResult Update(SkillUpdateDto model)
        {
            TempData["active"] = "yeteneklerim";
            if (ModelState.IsValid)
            {
                var skill = _skillGenericService.GetById(model.Id);
                skill.Description = model.Description;
                _skillGenericService.Update(skill);
                TempData["message"] = "Güncelleme işlemi başarılı";
                return RedirectToAction("Index");



            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "yeteneklerim";
            var skill = _skillGenericService.GetById(id);
            _skillGenericService.Delete(skill);
            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }
    }
}
