using System.ComponentModel.DataAnnotations;

namespace ARSProje.DapperCvAppWeb.Models
{
    public class AppUserLoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı gereklidir.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre gereklidir.")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
