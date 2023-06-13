using ARSProje.DapperCvAppDTO.DTOs.AppUserDtos;
using ARSProje.DapperCvAppDTO.DTOs.CertificationDtos;
using ARSProje.DapperCvAppDTO.DTOs.EducationDtos;
using ARSProje.DapperCvAppDTO.DTOs.ExperinceDtos;
using ARSProje.DapperCvAppDTO.DTOs.InterestDtos;
using ARSProje.DapperCvAppDTO.DTOs.SkillDtos;
using ARSProje.DapperCvAppDTO.DTOs.SocialMedioIconDto;
using ARSProje.DapperCvAppEntities.Concrate;
using AutoMapper;

namespace ARSProje.DapperCvAppWeb.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, AppUserListDto>();
            CreateMap<AppUserListDto, AppUser>();

            CreateMap<Certification, CertificationListDto>();
            CreateMap<CertificationListDto, Certification>();

            CreateMap<CertificationAddDto, Certification>();
            CreateMap<Certification, CertificationAddDto>();

            CreateMap<CertificationUpdateDto, Certification>();
            CreateMap<Certification, CertificationUpdateDto>();

            CreateMap<Education, EducationListDto>();
            CreateMap<EducationListDto, Education>();

            CreateMap<Education, EducationAddDto>();
            CreateMap<EducationAddDto, Education>();

            CreateMap<Education, EducationUpdateDto>();
            CreateMap<EducationUpdateDto, Education>();

            CreateMap<Experince, ExperinceListDto>();
            CreateMap<ExperinceListDto, Experince>();

            CreateMap<Experince, ExperinceAddDto>();
            CreateMap<ExperinceAddDto, Experince>();

            CreateMap<Experince, ExperinceUpdateDto>();
            CreateMap<ExperinceUpdateDto, Experince>();

            CreateMap<Interest, InterestListDto>();
            CreateMap<InterestListDto, Interest>();

            CreateMap<Interest, InterestAddDto>();
            CreateMap<InterestAddDto, Interest>();

            CreateMap<Interest, InterestUpdateDto>();
            CreateMap<InterestUpdateDto, Interest>();

            CreateMap<Skill, SkillListDto>();
            CreateMap<SkillListDto, Skill>();

            CreateMap<Skill, SkillAddDto>();
            CreateMap<SkillAddDto, Skill>();

            CreateMap<Skill, SkillUpdateDto>();
            CreateMap<SkillUpdateDto, Skill>();

            CreateMap<SocialMediaIcon, SocialMediaIconListDto>();
            CreateMap<SocialMediaIconListDto, SocialMediaIcon>();

            CreateMap<SocialMediaIcon, SocialMediaIconAddDto>();
            CreateMap<SocialMediaIconAddDto, SocialMediaIcon>();

            CreateMap<SocialMediaIcon, SocialMediaIconUpdateDto>();
            CreateMap<SocialMediaIconUpdateDto, SocialMediaIcon>();
        }
    }
}
