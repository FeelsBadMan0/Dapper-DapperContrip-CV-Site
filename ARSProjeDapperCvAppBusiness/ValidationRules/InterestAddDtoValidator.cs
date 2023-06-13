using ARSProje.DapperCvAppDTO.DTOs.InterestDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class InterestAddDtoValidator : AbstractValidator<InterestAddDto>
    {
        public InterestAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
