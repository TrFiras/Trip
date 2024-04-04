using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Data.Interfaces;

namespace Trip.Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContextClass _dbContext;

        protected GenericRepository(DbContextClass context)
        {
            _dbContext = context;
        }

        public   T GetById(int id)
        {
            return   _dbContext.Set<T>().Find(id);
        }

        public  IEnumerable<T> GetAll()
        {
            return  _dbContext.Set<T>().ToList();
        }

        public void Add(T entity)
        {
             _dbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }
    }
}
