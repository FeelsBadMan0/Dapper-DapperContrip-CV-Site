using ARSProje.DapperCvAppDTO.Interfaces;

namespace ARSProje.DapperCvAppDTO.DTOs.CertificationDtos
{
    public class CertificationUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
