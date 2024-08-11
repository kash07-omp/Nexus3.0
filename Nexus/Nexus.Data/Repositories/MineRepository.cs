using Nexus.Data.Infrastructure;
using Nexus.Model;

namespace Nexus.Data.Repositories
{
    public class MineRepository : RepositoryBase<Mine>, IMineRepository
    {
        public MineRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }

    public interface IMineRepository : IRepository<Mine>
    {
    }
}
