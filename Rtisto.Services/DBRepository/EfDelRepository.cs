using Rtisto.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Rtisto.Services.DBRepository
{
    public class EfDelRepository<T> : IDBRepository<T> where T : DelEntity
    {
        private DataAccessContext context;
        private DbSet<T> Entities;

        public EfDelRepository(DataAccessContext _context)
        {
            context = _context;
            Entities = context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            Entities.Add(entity);
        }

        public virtual void AddMany(List<T> entities)
        {
            Entities.AddRange(entities);
        }

        public virtual void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            entity.IsDeleted = true;
        }

        public virtual void DeleteMany(List<T> entities)
        {
            Entities.RemoveRange(entities);
        }

        public virtual List<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Entities.Where(a => !a.IsDeleted).AsNoTracking();

            if (includeProperties != null)
            {
                foreach (var prop in includeProperties)
                {
                    query = query.Include(prop);
                }
            }

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = orderBy(query);

            return query.ToList();
        }
        
        public virtual T GetSingle(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Entities.Where(a => !a.IsDeleted).AsNoTracking();

            if (includeProperties != null)
            {
                foreach (var prop in includeProperties)
                {
                    query = query.Include(prop);
                }
            }

            if (filter != null)
                query = query.Where(filter);

            return query.SingleOrDefault();
        }

        public T GetById(object id)
        {
            return Entities.Find(id);
        }
    }
}
