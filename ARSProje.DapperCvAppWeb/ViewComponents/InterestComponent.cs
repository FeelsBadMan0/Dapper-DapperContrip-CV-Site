using ARSProje.DapperCvAppDTO.DTOs.InterestDtos;
using ARSProje.DapperCvAppEntities.Concrate;
using ARSProjeDapperCvAppBusiness.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ARSProje.DapperCvAppWeb.ViewComponents
{
    public class InterestComponent : ViewComponent
    {
        private readonly IGenericService<Interest> _genericInterestService;
        private readonly IMapper _mapper;

        public InterestComponent(IGenericService<Interest> genericInterestService, IMapper mapper)
        {
            _genericInterestService = genericInterestService;
            _mapper = mapper;
        }


        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<InterestListDto>>(_genericInterestService.GetAll()));
        }
    }
}
