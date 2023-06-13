using ARSProje.DapperCvAppEntities.Concrate;
using System.Collections.Generic;

namespace ARSProjeDapperCvAppBusiness.Interfaces
{
    public interface ISocialMediaIconService : IGenericService<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
