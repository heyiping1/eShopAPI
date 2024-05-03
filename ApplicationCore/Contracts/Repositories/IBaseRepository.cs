using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IBaseRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Add(T entity);
        int Update(T entity);
        int Delete(int id);
        IEnumerable<T> Filter(Func<T, bool> predicate);
    }
}
