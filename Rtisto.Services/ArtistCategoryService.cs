using Rtisto.Core.Domain;
using Rtisto.Services.DBRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rtisto.Services
{
    public class ArtistCategoryService
    {
        DataAccessContext dbContext;
        EfDelRepository<ArtistCategory> ArtistCategoryRep;

        public ArtistCategoryService(string connectionString)
        {
            dbContext = new DataAccessContext(connectionString);
            ArtistCategoryRep = new EfDelRepository<ArtistCategory>(dbContext);
        }

        public void Add(ArtistCategory artistCategory)
        {
            ArtistCategoryRep.Add(artistCategory);
            dbContext.SaveChanges();
        }

        public void Update(ArtistCategory artistCategory)
        {
            ArtistCategoryRep.Update(artistCategory);
            dbContext.SaveChanges();
        }

        public void Delete(ArtistCategory artistCategory)
        {
            ArtistCategoryRep.Delete(artistCategory);
            dbContext.SaveChanges();
        }

        public void Delete(int categoryId)
        {
            ArtistCategory artistCategory = GetById(categoryId);
            Delete(artistCategory);
        }

        public List<ArtistCategory> GetAll(Expression<Func<ArtistCategory, bool>> filter = null, Func<IQueryable<ArtistCategory>, IOrderedQueryable<ArtistCategory>> orderBy = null,
            params Expression<Func<ArtistCategory, object>>[] includeProperties)
        {
            return ArtistCategoryRep.Get(filter, orderBy, includeProperties);
        }

        public ArtistCategory GetSingle(Expression<Func<ArtistCategory, bool>> filter = null, params Expression<Func<ArtistCategory, object>>[] includeProperties)
        {
            return ArtistCategoryRep.GetSingle(filter, includeProperties);
        }

        public ArtistCategory GetById(int id)
        {
            return ArtistCategoryRep.GetById(id);
        }

        public bool Exists(int id, string title)
        {
            return GetSingle(a => a.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase) && a.Id != id && !a.IsDeleted) != null;
        }
    }
}
