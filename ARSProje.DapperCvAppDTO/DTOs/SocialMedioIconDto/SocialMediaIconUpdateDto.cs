﻿using ARSProje.DapperCvAppDTO.Interfaces;

namespace ARSProje.DapperCvAppDTO.DTOs.SocialMedioIconDto
{
    public class SocialMediaIconUpdateDto : IDto
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
