using ARSProje.DapperCvAppEntities.Concrate;
using ARSProjeDapperCvAppBusiness.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ARSProje.DapperCvAppWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<Skill> _skillService;

        public HomeController(IGenericService<Skill> skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            return View(_skillService.GetAll());
        }
    }
}
