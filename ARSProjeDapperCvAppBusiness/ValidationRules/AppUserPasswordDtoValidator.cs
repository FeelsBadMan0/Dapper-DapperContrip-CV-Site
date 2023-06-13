using ARSProje.DapperCvAppDTO.DTOs.AppUserDtos;
using FluentValidation;

namespace ARSProjeDapperCvAppBusiness.ValidationRules
{
    public class AppUserPasswordDtoValidator : AbstractValidator<AppUserPasswordDto>
    {
        public AppUserPasswordDtoValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola bış geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Parola tekrar boş geçilemez");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Parolalar uyuşmuyor");
        }
    }
}
