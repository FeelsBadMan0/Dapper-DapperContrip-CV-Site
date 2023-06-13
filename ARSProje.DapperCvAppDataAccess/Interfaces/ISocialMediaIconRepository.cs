using ARSProje.DapperCvAppEntities.Concrate;
using System.Collections.Generic;

namespace ARSProje.DapperCvAppDataAccess.Interfaces
{
    public interface ISocialMediaIconRepository : IGenericRepository<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
