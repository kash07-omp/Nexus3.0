using Nexus.Data.Infrastructure;
using Nexus.Model;

namespace Nexus.Data.Repositories
{
    public class RegionRepository : RepositoryBase<Region>, IRegionRepository
    {
        public RegionRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }

    public interface IRegionRepository : IRepository<Region>
    {
    }
}
