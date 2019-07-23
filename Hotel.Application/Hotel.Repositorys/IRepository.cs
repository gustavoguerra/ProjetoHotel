using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Repositorys
{
    public interface IRepository<TEntity>
    {
        void Save(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        IEnumerable<TEntity> Getall();

        TEntity GetById(int id);

        List<TEntity> Find(Func<TEntity, bool> predicate);
    }
}
