using ARSProje.DapperCvAppDTO.DTOs.ExperinceDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class ExperinceAddDtoValidator : AbstractValidator<ExperinceAddDto>
    {
        public ExperinceAddDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Alt başlık boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");
        }
    }
}
