using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        IEnumerable<T> FindAll();
        T Find(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T id);
        bool Save();
    }
}
