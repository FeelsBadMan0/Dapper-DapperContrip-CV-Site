using ARSProje.DapperCvAppDataAccess.Concrate.Dapper;
using ARSProje.DapperCvAppDataAccess.Interfaces;
using ARSProje.DapperCvAppDTO.DTOs.AppUserDtos;
using ARSProje.DapperCvAppDTO.DTOs.CertificationDtos;
using ARSProje.DapperCvAppDTO.DTOs.EducationDtos;
using ARSProje.DapperCvAppDTO.DTOs.ExperinceDtos;
using ARSProje.DapperCvAppDTO.DTOs.InterestDtos;
using ARSProje.DapperCvAppDTO.DTOs.SkillDtos;
using ARSProje.DapperCvAppDTO.DTOs.SocialMedioIconDto;
using ARSProjeDapperCvAppBusiness.Concrate;
using ARSProjeDapperCvAppBusiness.Interfaces;
using ARSProjeDapperCvAppBusiness.ValidationRules;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace ARSProjeDapperCvAppBusiness.IOC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddCustomDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con => new SqlConnection(configuration.GetConnectionString("connectionMssql")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IAppUserRepository, DpAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<ISocialMediaIconRepository, DpSocialMediaIconRepository>();
            services.AddScoped<ISocialMediaIconService, SocialMediaIconManager>();


            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserPasswordDto>, AppUserPasswordDtoValidator>();
            services.AddTransient<IValidator<CertificationAddDto>, CertificationAddDtoValidator>();
            services.AddTransient<IValidator<CertificationUpdateDto>, CertificationUpdateDtoValidator>();
            services.AddTransient<IValidator<EducationAddDto>, EducationAddDtoValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateDtoValidator>();
            services.AddTransient<IValidator<ExperinceAddDto>, ExperinceAddDtoValidator>();
            services.AddTransient<IValidator<ExperinceUpdateDto>, ExperienceUpdateDtoValidator>();
            services.AddTransient<IValidator<InterestAddDto>, InterestAddDtoValidator>();
            services.AddTransient<IValidator<InterestUpdateDto>, InterestUpdateDtoValidator>();
            services.AddTransient<IValidator<SkillAddDto>, SkillAddDtoValidator>();
            services.AddTransient<IValidator<SkillUpdateDto>, SkillUpdateDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconAddDto>, SocialMediaIconAddDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconUpdateDto>, SocialMediaIconUpdateDtoValidator>();
        }
    }
}
