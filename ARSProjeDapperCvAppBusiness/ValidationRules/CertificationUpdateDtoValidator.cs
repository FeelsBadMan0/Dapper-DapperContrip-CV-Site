using ARSProje.DapperCvAppDTO.DTOs.CertificationDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class CertificationUpdateDtoValidator : AbstractValidator<CertificationUpdateDto>
    {
        public CertificationUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(y => y.Description).NotEmpty().WithMessage("Sertifika alanı boş geçilemez");
        }
    }
}
