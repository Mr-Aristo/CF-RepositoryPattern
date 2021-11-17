using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository.Abstract;
using DAL.Entities;

namespace DAL.Repository.Concrete
{
    public class Repository<T>: IRepository<T> where T :class
    {
        protected DbContext _context;
        private DbSet<T> _dbset;
        public Repository(DbContext context) 
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbset.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }

        public T GetByID(int id)
        {
            return _dbset.Find(id);
        }

        public void Remove(int id)
        {
           _dbset.Remove(GetByID(id));
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        List<T> IRepository<T>.GetAll()
        {
            return _dbset.ToList();
        }
    }
}
