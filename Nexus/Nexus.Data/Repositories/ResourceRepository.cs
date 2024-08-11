using Nexus.Data.Infrastructure;
using Nexus.Model;

namespace Nexus.Data.Repositories
{
    public class ResourceRepository : RepositoryBase<Resource>, IResourceRepository
    {
        public ResourceRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public Resource GetByCode(string code)
        {
            return this.DbContext.Resources.FirstOrDefault(r => r.Code == code);
        }
    }

    public interface IResourceRepository : IRepository<Resource>
    {
        Resource GetByCode(string code);
    }
}
