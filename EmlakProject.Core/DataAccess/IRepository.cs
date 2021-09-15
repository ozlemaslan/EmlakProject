using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EmlakProject.Core.DataAccess
{
    public interface IRepository<TEntity>
        where TEntity : BaseModel
    {
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
