using ARSProje.DapperCvAppDataAccess.Interfaces;
using ARSProje.DapperCvAppEntities.Concrate;
using ARSProjeDapperCvAppBusiness.Interfaces;
using System.Collections.Generic;

namespace ARSProjeDapperCvAppBusiness.Concrate
{
    public class SocialMediaIconManager : GenericManager<SocialMediaIcon>, ISocialMediaIconService
    {
        private readonly IGenericRepository<SocialMediaIcon> _socialMediaGenericRepository;
        private readonly ISocialMediaIconRepository _socialMediaIconRepository;
        public SocialMediaIconManager(IGenericRepository<SocialMediaIcon> socialMediaGenericRepository, ISocialMediaIconRepository socialMediaIconRepository) : base(socialMediaGenericRepository)
        {
            _socialMediaGenericRepository = socialMediaGenericRepository;
            _socialMediaIconRepository = socialMediaIconRepository;
        }
        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _socialMediaIconRepository.GetByUserId(userId);
        }
    }
}
