using leave_management.Contracts;
using leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repositories
{
    public class RepositoryBase<T> :IRepositoryBase<T> where T:class
    {
        protected ApplicationDbContext applicationDbContext;

        public RepositoryBase(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public bool Create(T entity)
        {
            applicationDbContext.Add(entity);
            return true;
        }

        public bool Delete(T id)
        {
            applicationDbContext.Remove(id);
            return true;
        }

        public virtual T Find(int id)
        {
           return applicationDbContext.Find<T>(id);
        }

        public IEnumerable<T> FindAll()
        {
            return applicationDbContext.Set<T>();
        }

        public bool Save()
        {
            return applicationDbContext.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            applicationDbContext.Update(entity);
            return true;
        }
    }
}
