using ARSProje.DapperCvAppDTO.Interfaces;

namespace ARSProje.DapperCvAppDTO.DTOs.InterestDtos
{
    public class InterestUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
