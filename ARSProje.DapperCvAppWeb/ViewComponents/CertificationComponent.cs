using ARSProje.DapperCvAppDTO.DTOs.CertificationDtos;
using ARSProje.DapperCvAppEntities.Concrate;
using ARSProjeDapperCvAppBusiness.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ARSProje.DapperCvAppWeb.ViewComponents
{
    public class CertificationComponent : ViewComponent
    {
        private readonly IGenericService<Certification> _genericCertificationService;
        private readonly IMapper _mapper;
        public CertificationComponent(IGenericService<Certification> genericCertificationService, IMapper mapper)
        {
            _genericCertificationService = genericCertificationService;
            _mapper = mapper;
        }


        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<CertificationListDto>>(_genericCertificationService.GetAll()));
        }
    }
}
