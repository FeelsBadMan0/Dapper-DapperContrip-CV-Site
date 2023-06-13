using ARSProje.DapperCvAppDTO.DTOs.ExperinceDtos;
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
    public class ExperinceController : Controller
    {
        private readonly IGenericService<Experince> _experinceGenericService;
        private readonly IMapper _mapper;

        public ExperinceController(IGenericService<Experince> experinceGenericService, IMapper mapper)
        {
            _experinceGenericService = experinceGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "deneyimlerim";

            return View(_mapper.Map<List<ExperinceListDto>>(_experinceGenericService.GetAll()));
        }

        public IActionResult Add()
        {
            TempData["active"] = "deneyimlerim";

            return View(new ExperinceAddDto());
        }

        [HttpPost]
        public IActionResult Add(ExperinceAddDto model)
        {
            TempData["active"] = "deneyimlerim";
            if (ModelState.IsValid)
            {
                _experinceGenericService.Insert(_mapper.Map<Experince>(model));
                TempData["message"] = "Ekleme işleminiz başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "deneyimlerim";
            return View(_mapper.Map<ExperinceUpdateDto>(_experinceGenericService.GetById(id)));

        }

        [HttpPost]
        public IActionResult update(ExperinceUpdateDto model)
        {
            TempData["active"] = "deneyimlerim";
            if (ModelState.IsValid)
            {
                var deneyim = _experinceGenericService.GetById(model.Id);
                deneyim.Title = model.Title;
                deneyim.SubTitle = model.SubTitle;
                deneyim.Description = model.Description;
                deneyim.StartDate = model.StartDate;
                deneyim.EndDate = model.EndDate;
                _experinceGenericService.Update(deneyim);
                TempData["message"] = "Güncelleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "deneyimlerim";
            var deneyim = _experinceGenericService.GetById(id);
            _experinceGenericService.Delete(deneyim);
            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");

        }
    }
}
