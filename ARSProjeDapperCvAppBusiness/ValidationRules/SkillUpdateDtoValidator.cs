using ARSProje.DapperCvAppDTO.DTOs.SkillDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class SkillUpdateDtoValidator : AbstractValidator<SkillUpdateDto>
    {
        public SkillUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
