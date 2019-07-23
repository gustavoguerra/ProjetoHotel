using Hotel.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Repositorys
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected static List<TEntity> _data;
        private static readonly object _sysnc = new object();

        public Repository()
        {
            if(_data == null)
            {
                lock(_sysnc)
                {
                    if(_data == null)
                    {
                        _data = new List<TEntity>();
                    }
                }
            }
        }

        public Repository(List<TEntity> data)
        {
            _data = data;
        }
            
        public void Delete(string entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return _data.Where(predicate).ToList();
        }

        public IEnumerable<TEntity> Getall()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
