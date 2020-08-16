using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rtisto.Services.DBRepository
{
    interface IDBRepository<T> where T : class
    {
        void Add(T entity);
        void AddMany(List<T> entities);
        void Update(T entity);
        void Delete(T entity);
        void DeleteMany(List<T> entities);
        List<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includeProperties);
        T GetSingle(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties);
        T GetById(object id);
    }
}
