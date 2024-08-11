using Nexus.Data.Infrastructure;
using Nexus.Model;

namespace Nexus.Data.Repositories
{
    public class RegionStructureRepository : RepositoryBase<RegionStructure>, IRegionStructureRepository
    {
        public RegionStructureRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<RegionStructure> GetByRegionId(int regionId)
        {
            return this.DbContext.RegionStructures.Where(rs => rs.RegionId == regionId).ToList();
        }
    }

    public interface IRegionStructureRepository : IRepository<RegionStructure>
    {
        IEnumerable<RegionStructure> GetByRegionId(int regionId);
    }
}
