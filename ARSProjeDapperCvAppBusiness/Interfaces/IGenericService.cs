using ARSProje.DapperCvAppEntities.Interfaces;
using System.Collections.Generic;

namespace ARSProjeDapperCvAppBusiness.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
