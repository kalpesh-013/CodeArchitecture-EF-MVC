using Rtisto.Core.Domain;
using System.Data.Entity;

namespace Rtisto.Services.DBRepository
{
    public class DataAccessContext : DbContext
    {
        public DataAccessContext(string ConnectionString)
            : base(ConnectionString)
        {
        }

        public DbSet<ArtistCategory> ArtistCategories { get; set; }
    }
}
