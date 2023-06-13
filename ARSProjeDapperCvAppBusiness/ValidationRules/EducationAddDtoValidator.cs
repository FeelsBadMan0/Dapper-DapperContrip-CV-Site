using ARSProje.DapperCvAppDTO.DTOs.EducationDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class EducationAddDtoValidator : AbstractValidator<EducationAddDto>
    {
        public EducationAddDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.SubTitle).NotEmpty().WithMessage("Alt başlık boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz");
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");
        }
    }
}
