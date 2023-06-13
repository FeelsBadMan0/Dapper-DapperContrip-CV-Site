using ARSProje.DapperCvAppDTO.DTOs.InterestDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class InterestUpdateDtoValidator : AbstractValidator<InterestUpdateDto>
    {
        public InterestUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");

        }
    }
}
