using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ARSProje.DapperCvAppWeb.Models
{
    public class AppUserUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad gereklidir")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad gereklidir")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Adres gereklidir")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Mail gereklidir")]
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Telefon numarası gereklidir")]
        public string PhoneNumber { get; set; }

        public IFormFile Picture { get; set; }
        [Required(ErrorMessage = "Ön yazı gereklidir")]
        public string ShortDescription { get; set; }
    }
}
