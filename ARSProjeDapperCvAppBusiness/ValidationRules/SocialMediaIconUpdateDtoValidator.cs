using ARSProje.DapperCvAppDTO.DTOs.SocialMedioIconDto;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class SocialMediaIconUpdateDtoValidator : AbstractValidator<SocialMediaIconUpdateDto>
    {
        public SocialMediaIconUpdateDtoValidator()
        {

            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(x => x.Link).NotEmpty().WithMessage("Link alanı boş geçilemez");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("İkon alanı boş geçilemez");

        }
    }
}
