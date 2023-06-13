using ARSProje.DapperCvAppDTO.DTOs.ExperinceDtos;
using ARSProje.DapperCvAppEntities.Concrate;
using ARSProjeDapperCvAppBusiness.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ARSProje.DapperCvAppWeb.ViewComponents
{
    public class ExperinceComponent : ViewComponent
    {
        private readonly IGenericService<Experince> _genericExperinceService;
        private readonly IMapper _mapper;
        public ExperinceComponent(IGenericService<Experince> genericExperinceService, IMapper mapper)
        {
            _genericExperinceService = genericExperinceService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ExperinceListDto>>(_genericExperinceService.GetAll()));
        }
    }
}
