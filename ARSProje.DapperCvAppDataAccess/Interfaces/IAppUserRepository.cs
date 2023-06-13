using ARSProje.DapperCvAppEntities.Concrate;

namespace ARSProje.DapperCvAppDataAccess.Interfaces
{
    public interface IAppUserRepository : IGenericRepository<AppUser>
    {
        /// <summary>
        /// Eğer user var ise true döner yoksa false döner
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);

        AppUser FindByName(string userName);
    }
}
