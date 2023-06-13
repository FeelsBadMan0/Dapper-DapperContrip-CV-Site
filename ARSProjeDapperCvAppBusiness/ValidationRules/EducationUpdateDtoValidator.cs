using ARSProje.DapperCvAppDTO.DTOs.EducationDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class EducationUpdateDtoValidator : AbstractValidator<EducationUpdateDto>
    {
        public EducationUpdateDtoValidator()
        {
            RuleFor(x => x.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Alt başlık boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");

        }
    }
}
