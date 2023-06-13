using ARSProje.DapperCvAppDTO.DTOs.EducationDtos;
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
    public class EducationController : Controller
    {
        private readonly IGenericService<Education> _educationGenericService;
        private readonly IMapper _mapper;

        public EducationController(IGenericService<Education> educationGenericService, IMapper mapper)
        {
            _educationGenericService = educationGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "egitimlerim";
            return View(_mapper.Map<List<EducationListDto>>(_educationGenericService.GetAll()));
        }

        public IActionResult Delete(int id)
        {

            TempData["active"] = "egitimlerim";
            var deletedEntity = _educationGenericService.GetById(id);
            _educationGenericService.Delete(deletedEntity);
            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }

        public IActionResult Add()
        {
            TempData["active"] = "egitimlerim";
            return View(new EducationAddDto());
        }

        [HttpPost]
        public IActionResult Add(EducationAddDto model)
        {
            TempData["active"] = "egitimlerim";
            if (ModelState.IsValid)
            {

                _educationGenericService.Insert(_mapper.Map<Education>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "egitimlerim";
            return View(_mapper.Map<EducationUpdateDto>(_educationGenericService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(EducationUpdateDto model)
        {
            TempData["active"] = "egitimlerim";
            if (ModelState.IsValid)
            {
                var education = _educationGenericService.GetById(model.Id);
                education.StartDate = model.StartDate;
                education.EndDate = model.EndDate;
                education.Title = model.Title;
                education.SubTitle = model.SubTitle;
                education.Description = model.Description;
                _educationGenericService.Update(education);
                TempData["message"] = "Güncelleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
