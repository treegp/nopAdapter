using System.Collections.Generic;

namespace nopAdapter.EntityAbstracts
{
    public interface IGenericRepo<TEntity>

    {
        TEntity Insert(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Update(TEntity entity);
        List<TEntity> GetAll();
        TEntity Top();
        int Count();
    }
}
