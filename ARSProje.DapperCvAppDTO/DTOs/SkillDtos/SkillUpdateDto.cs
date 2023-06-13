using ARSProje.DapperCvAppDTO.Interfaces;

namespace ARSProje.DapperCvAppDTO.DTOs.SkillDtos
{
    public class SkillUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
