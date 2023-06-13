using ARSProje.DapperCvAppDTO.Interfaces;

namespace ARSProje.DapperCvAppDTO.DTOs.AppUserDtos
{
    public class AppUserPasswordDto : IDto
    {
        public int Id { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
