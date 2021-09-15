using System;
using System.Collections.Generic;
using System.Text;

namespace EmlakProject.BLL.Abstract
{
    public interface IBaseService<TEntity>
    {
        bool Add(TEntity entity);
        bool Delete(int entityID);
        bool Update(TEntity entity);
        TEntity GetByID(int entityID);
        List<TEntity> GetAll();
    }
}
