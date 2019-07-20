using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Repository
{
    public class IRepository<TEntity>
    {
        void Save(TEntity entity);

        IEnumerable<TEntity> Getall();

        TEntity GetByTaype(int id);
    }
}
