using Nexus.Data.Infrastructure;
using Nexus.Model;

namespace Nexus.Data.Repositories
{
    public class PlanetRepository : RepositoryBase<Planet>, IPlanetRepository
    {
        public PlanetRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }

    public interface IPlanetRepository : IRepository<Planet>
    {
    }
}
