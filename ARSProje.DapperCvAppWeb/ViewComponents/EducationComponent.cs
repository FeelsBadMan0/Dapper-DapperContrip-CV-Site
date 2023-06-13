using ARSProje.DapperCvAppDTO.DTOs.EducationDtos;
using ARSProje.DapperCvAppEntities.Concrate;
using ARSProjeDapperCvAppBusiness.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ARSProje.DapperCvAppWeb.ViewComponents
{
    public class EducationComponent : ViewComponent
    {
        private readonly IGenericService<Education> _genericEducationService;
        private readonly IMapper _mapper;

        public EducationComponent(IGenericService<Education> genericEducationService, IMapper mapper)
        {
            _genericEducationService = genericEducationService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<EducationListDto>>(_genericEducationService.GetAll()));
        }
    }
}
