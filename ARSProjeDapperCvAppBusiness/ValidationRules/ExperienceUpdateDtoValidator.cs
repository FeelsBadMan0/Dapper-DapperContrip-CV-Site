using ARSProje.DapperCvAppDTO.DTOs.ExperinceDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class ExperienceUpdateDtoValidator : AbstractValidator<ExperinceUpdateDto>
    {
        public ExperienceUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id kısmı boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Alt başlık boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");

        }
    }
}
