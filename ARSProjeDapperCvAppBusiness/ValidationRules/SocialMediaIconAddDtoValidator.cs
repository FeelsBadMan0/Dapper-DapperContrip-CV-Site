using ARSProje.DapperCvAppDTO.DTOs.SocialMedioIconDto;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class SocialMediaIconAddDtoValidator : AbstractValidator<SocialMediaIconAddDto>
    {
        public SocialMediaIconAddDtoValidator()
        {
            RuleFor(x => x.Link).NotEmpty().WithMessage("Link alanı boş geçilemez");
            RuleFor(x => x.Icon).NotEmpty().WithMessage("İkon alanı boş geçilemez");

        }
    }
}
