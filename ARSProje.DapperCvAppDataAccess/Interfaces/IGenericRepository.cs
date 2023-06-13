using ARSProje.DapperCvAppEntities.Interfaces;
using System.Collections.Generic;

namespace ARSProje.DapperCvAppDataAccess.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, ITable, new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
