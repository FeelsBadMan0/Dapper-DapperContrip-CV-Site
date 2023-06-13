using ARSProje.DapperCvAppDataAccess.Interfaces;
using ARSProje.DapperCvAppEntities.Concrate;
using Dapper;
using System.Data;

namespace ARSProje.DapperCvAppDataAccess.Concrate.Dapper
{
    public class DpAppUserRepository : DpGenericRepository<AppUser>, IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpAppUserRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool CheckUser(string userName, string password)
        {
            var user = _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where UserName=@userName and Password=@password", new
            {
                userName = userName,
                password = password
            });
            return user != null;
        }

        public AppUser FindByName(string userName)
        {
            return _dbConnection.QueryFirstOrDefault<AppUser>("Select * from AppUsers where UserName=@p1", new
            {
                p1 = userName
            });
        }
    }
}
