using ARSProje.DapperCvAppDTO.DTOs.InterestDtos;
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
    public class InterestController : Controller
    {
        private readonly IGenericService<Interest> _interestGenericService;
        private readonly IMapper _mapper;

        public InterestController(IGenericService<Interest> interestGenericService, IMapper mapper)
        {
            _interestGenericService = interestGenericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "hobilerim";
            return View(_mapper.Map<List<InterestListDto>>(_interestGenericService.GetAll()));
        }

        public IActionResult Add()
        {
            TempData["active"] = "hobilerim";
            return View(new InterestAddDto());
        }

        [HttpPost]
        public IActionResult Add(InterestAddDto model)
        {
            TempData["active"] = "hobilerim";
            if (ModelState.IsValid)
            {
                _interestGenericService.Insert(_mapper.Map<Interest>(model));
                TempData["message"] = "Ekleme işlemi başarılı";
                return RedirectToAction("Index");
            }
            return View(model);

        }

        public IActionResult Update(int id)
        {
            TempData["active"] = "hobilerim";
            return View(_mapper.Map<InterestUpdateDto>(_interestGenericService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(InterestUpdateDto model)
        {
            TempData["active"] = "hobilerim";
            if (ModelState.IsValid)
            {
                var hobi = _interestGenericService.GetById(model.Id);
                hobi.Description = model.Description;
                _interestGenericService.Update(hobi);
                TempData["message"] = "Güncelleme işlemi başarılı";
                return RedirectToAction("Index");

            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "hobilerim";
            var hobi = _interestGenericService.GetById(id);
            _interestGenericService.Delete(hobi);
            TempData["message"] = "Silme işlemi başarılı";
            return RedirectToAction("Index");
        }
    }
}
