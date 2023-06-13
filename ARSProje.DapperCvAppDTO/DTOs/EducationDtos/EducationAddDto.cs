using ARSProje.DapperCvAppDTO.Interfaces;
using System;

namespace ARSProje.DapperCvAppDTO.DTOs.EducationDtos
{
    public class EducationAddDto : IDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
    }
}
