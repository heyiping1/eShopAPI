using ApplicationCore.Contracts.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly EShopDbContext _context;

        public BaseRepository(EShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            T item = _context.Set<T>().Find(id);
            if (item != null)
            {
                return item;
            }
            return default(T);
        }

        public int Add(T entity )
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }

        public int Update(T entity)
        {
            _context.Set<T>().Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            var i = GetById(id);
            if (i != null)
            {
                _context.Set<T>().Remove(i);
                return _context.SaveChanges();
            }
            return 0;
        }

        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList();
        }
    }
}
