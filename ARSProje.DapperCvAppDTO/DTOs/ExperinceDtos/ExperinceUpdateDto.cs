﻿using ARSProje.DapperCvAppDTO.Interfaces;
using System;

namespace ARSProje.DapperCvAppDTO.DTOs.ExperinceDtos
{
    public class ExperinceUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
