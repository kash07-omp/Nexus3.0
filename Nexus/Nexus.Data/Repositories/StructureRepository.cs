using Nexus.Data.Infrastructure;
using Nexus.Model;

namespace Nexus.Data.Repositories
{
    public class StructureRepository : RepositoryBase<Structure>, IStructureRepository
    {
        public StructureRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }

    public interface IStructureRepository : IRepository<Structure>
    {
    }
}
