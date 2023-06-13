using ARSProje.DapperCvAppEntities.Concrate;

namespace ARSProjeDapperCvAppBusiness.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        /// <summary>
        /// Eğer user var ise true döner yoksa false döner
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);
        public AppUser FindByName(string userName);
    }
}
