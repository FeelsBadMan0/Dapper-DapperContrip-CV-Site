using ARSProje.DapperCvAppDTO.DTOs.SkillDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class SkillAddDtoValidator : AbstractValidator<SkillAddDto>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");

        }
    }
}
