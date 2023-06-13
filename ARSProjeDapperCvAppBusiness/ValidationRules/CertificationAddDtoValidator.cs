using ARSProje.DapperCvAppDTO.DTOs.CertificationDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class CertificationAddDtoValidator : AbstractValidator<CertificationAddDto>
    {
        public CertificationAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Sertifika alanı boş geçilemez");
        }
    }
}
