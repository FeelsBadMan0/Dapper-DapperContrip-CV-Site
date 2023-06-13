using ARSProje.DapperCvAppDTO.DTOs.SkillDtos;
using ARSProje.DapperCvAppEntities.Concrate;
using ARSProjeDapperCvAppBusiness.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ARSProje.DapperCvAppWeb.ViewComponents
{

    public class SkillComponent : ViewComponent
    {
        private readonly IGenericService<Skill> _skillGenericService;
        private readonly IMapper _mapper;

        public SkillComponent(IGenericService<Skill> skillGenericService, IMapper mapper)
        {
            _skillGenericService = skillGenericService;
            _mapper = mapper;
        }


        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDto>>(_skillGenericService.GetAll()));
        }
    }
}
